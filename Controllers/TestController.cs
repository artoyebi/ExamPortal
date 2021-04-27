using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortal.Data;
using ExamPortal.Models;
using ExamPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExamPortal.Controllers
{
    public class TestController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ITestRepository testRepository;
        private readonly ApplicationDbContext context;

        public TestController(RoleManager<IdentityRole> roleManager, ITestRepository testRepository, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.testRepository = testRepository;
            this.context = context;
        }

        [HttpGet]
        public IActionResult CreateTest()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTest(CreateTestViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                Test test = new Test
                {
                    //Id = Guid.NewGuid(),
                    Description = model.Description,
                    Instruction = model.Instruction,
                    CreatedBy = model.CreatedBy,
                    Duration = model.Duration,
                    AvailableFrom = model.AvailableFrom,
                    AvailableTill = model.AvailableTill,
                    //NumberofQstns = model.NumberofQstns


                };



                var result =  context.Tests.Add(test);
                //var status = result.IsCompletedSuccessfully;
                var save =  context.SaveChanges();
                //var saveStatus = save.IsCompletedSuccessfully;


                //return View();
                return RedirectToAction("dashboard", "examiner");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                
            }
           // }
            
            return View(model);
            
        }


        [HttpGet]
        [Authorize(Roles = "Examiner")]
        public IActionResult AddQuestion(Guid testId)
        {
            var test = testRepository.FindTest(testId);
            if (test == null)
            {
                return View("NotFound");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddQuestion(AddQuestionViewModel model)
        {
            //var findTest = testRepository.FindTest(testId);
            //if (findTest == null)
            //{
            //    return View("NotFound");
            //}

            if (ModelState.IsValid)
            {
                QuestionAndAnswer questionAndAnswer = new QuestionAndAnswer
                {
                    Id = Guid.NewGuid(),
                    Question = model.Question,
                    Answer = model.Answer,
                    Option1 = model.Option1,
                    Option2 = model.Option2,
                    Option3 = model.Option3,
                    AssignedScore = model.AssignedScore,
                    TestId = model.TestId                
                };

                testRepository.AddQuestions(questionAndAnswer);
                
                return RedirectToAction("dashboard", "examiner");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Examiner, Admin")]
        public IActionResult TestDetails(Guid testId)
        {
            var test = testRepository.FindTest(testId);
            //List<QuestionAndAnswer> questionAndAnswers = new List<QuestionAndAnswer>();
            if (test == null)
            {
                return NotFound(test);
            }
            TestDetailViewModel model = new TestDetailViewModel
            {
                Test = testRepository.FindTest(testId),
                QuestionAndAnswers = testRepository.LoadTestQuestions(testId)
                
            };

            return View(model);

        }

        [HttpGet]
        public IActionResult EditQuestion(Guid questionId)
        {
            var question = testRepository.FindQuestion(questionId);
            if (question == null)
            {
                return NotFound();
            }
            EditQuestionViewModel model = new EditQuestionViewModel
            {
                Question = question.Question,
                Answer = question.Answer,
                AssignedScore = question.AssignedScore,
                Option1 = question.Option1,
                Option2 = question.Option2,
                Option3 = question.Option3,
                TestId = question.TestId,
                Id = question.Id
                
            };



            return View(model);
        }


        [HttpPost]
        public IActionResult EditQuestion(EditQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var question = testRepository.FindQuestion(model.Id);
                question.Question = model.Question;
                question.Answer = model.Answer;
                question.Option1 = model.Option1;
                question.Option2 = model.Option2;
                question.Option3 = model.Option3;
                question.AssignedScore = model.AssignedScore;

                testRepository.UpdateQuestion(question);

                return RedirectToAction("dashboard", "examiner");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult EditTest(TestDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var testUpdate = testRepository.FindTest(model.Test.Id);
                if (testUpdate == null)
                {
                    return NotFound(testUpdate);
                }
                testUpdate.Description = model.Test.Description;
                testUpdate.Instruction = model.Test.Instruction;
                testUpdate.Duration = model.Test.Duration;
                testUpdate.CreatedBy = model.Test.CreatedBy;
                testUpdate.AvailableFrom = model.Test.AvailableFrom;
                testUpdate.AvailableTill = model.Test.AvailableTill;

                testRepository.UpdateTest(testUpdate);
                return RedirectToAction("dashboard", "examiner");
            }

            return View(model);

        }


        
        public IActionResult DeleteTest(Guid testId)
        {
            var deleteTest = testRepository.FindTest(testId);
            if (deleteTest == null)
            {
                return NotFound();
            }
            testRepository.DeleteTest(deleteTest);
            return RedirectToAction("dashboard", "examiner");
        }

        
        public IActionResult DeleteQuestion(Guid questionId)
        {
            var deleteQuestion = testRepository.FindQuestion(questionId);
            if (deleteQuestion == null)
            {
                return NotFound();
            }
            testRepository.DeleteQuestion(deleteQuestion);
            return RedirectToAction("dashboard", "examiner");
        }

        [HttpGet]
        public IActionResult TakeTest(Guid testId)
        {

            int qstn = 1;
            int qstnPerpage = 1;
            int start = (qstn - 1) * qstnPerpage;
            ViewBag.qstn = qstn;
            var test = testRepository.FindTest(testId);
            IEnumerable<QuestionAndAnswer> questions = testRepository.LoadTestQuestions(testId);
            var TakeTestVM = new TakeTestViewModel
            {
                Test = test,
                Questions = questions.OrderBy(q => q.Id).Skip(start).Take(qstnPerpage),
                PageCount = Convert.ToInt32(Math.Ceiling(questions.Count() / (double)qstnPerpage))

            };

            return View(TakeTestVM);
        }


        [HttpGet]
        public IActionResult LoadQuestions(Guid testId, int qstn = 1)
        {
            if (testId == default)
            {
                return BadRequest(new {message = "Error from Controller" });
            }
            int qstnPerpage = 1;
            int start = (qstn - 1) * qstnPerpage;
            ViewBag.qsn = qstn;
            //var test = testRepository.FindTest(testId);
            IEnumerable<QuestionAndAnswer> questions = testRepository.LoadTestQuestions(testId);
            //var TakeTestVM = new TakeTestViewModel
            //{
            //    Test = test,
            //    Questions = questions.OrderBy(q => q.Id).Skip(start).Take(qstnPerpage),
            //    PageCount = Convert.ToInt32(Math.Ceiling(questions.Count() / (double)qstnPerpage))

            //};

            return Ok(questions.OrderBy(q => q.Id).Skip(start).Take(qstnPerpage));

        }


        
    }
}

