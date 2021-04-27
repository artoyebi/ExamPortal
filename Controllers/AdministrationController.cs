
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortal.Models;
using ExamPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExamPortal.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ITestRepository testRepository;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationController(ITestRepository testRepository, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.testRepository = testRepository;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Dashboard()
        {
            return View(testRepository.ListTests());
        }

        [HttpGet]
        public IActionResult AddCandidateToTest(Guid testid)
        {
            var test = testRepository.FindTest(testid);
            ViewBag.TestDescription = test.Description;
            ViewBag.testId = test.Id;
            if (test == null)
            {
                return NotFound(test);
            }
            var model = new List<AddCandidateToTestViewModel>();

            

            foreach (var user in userManager.Users.ToList())
            {
                //if (await userManager.IsInRoleAsync(user, "Candidate"))
                //{
                    var addCandidateToTestVM = new AddCandidateToTestViewModel
                    {
                        FirstName = user.FirstName,
                        Lastname = user.LastName,
                        CandidateId = user.Id
                    }; 
                    if (testRepository.IsCandidateInTest(user.Id, test.Id))
                    {
                        addCandidateToTestVM.IsSelected = true;
                    }
                    else
                    {
                        addCandidateToTestVM.IsSelected = false;
                    }
                    model.Add(addCandidateToTestVM);
                //}
                

            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AddCandidateToTest([FromForm]Guid testid, List<AddCandidateToTestViewModel> model)
        {
            var test = testRepository.FindTest(testid);
            
            if (ModelState.IsValid)
            {
                if (test == null)
                {
                    return NotFound(test);
                }
                for (int i = 0; i < model.Count; i++)
                {
                    var user = await userManager.FindByIdAsync(model[i].CandidateId);
                    //IdentityResult result = null;

                    if (model[i].IsSelected && !testRepository.IsCandidateInTest(model[i].CandidateId, testid))
                    {
                        testRepository.AddToTest(model[i].CandidateId, testid);
                    }
                    else if (!model[i].IsSelected && testRepository.IsCandidateInTest(model[i].CandidateId, testid))
                    {
                        testRepository.RemoveFromTest(model[i].CandidateId, testid);
                    }
                    else
                    {
                        continue;
                    }

                }
            }

            return RedirectToAction("dashboard", "administration");
        }
    }
}
