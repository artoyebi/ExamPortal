using ExamPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class TestServices : ITestRepository
    {
        private readonly ApplicationDbContext db;

        public TestServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<QuestionAndAnswer> AddQuestions(QuestionAndAnswer questionAndAnswer)
        {
            await db.QuestionAndAnswers.AddAsync(questionAndAnswer);
            await db.SaveChangesAsync();
            return questionAndAnswer;
        }

        public async Task<Test> AddTest(Test test)
        {
            await db.Tests.AddAsync(test);
            await db.SaveChangesAsync();
            return test;
            
        }

        public bool IsCandidateInTest(string userId, Guid testId)
        {
            //await db.CandidateInTests.Distinct()

            var res = db.CandidateInTests.Where(user => user.CandidateId == userId && user.TestId == testId);
            if (res.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

            //var result = db.CandidateInTests.Where(user => user.TestId == testId).Where(user => user.CandidateId == userId);
            ////var result = await db.CandidateInTests.FirstOrDefaultAsync(user => user.CandidateId == userId);
            //if (result == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public void DeleteQuestion(QuestionAndAnswer question)
        {
            db.QuestionAndAnswers.Remove(question);
            db.SaveChangesAsync();
        }

        public async void DeleteTest(Test test)
        {
            db.Tests.Remove(test);
            await db.SaveChangesAsync();
        }

        public QuestionAndAnswer FindQuestion(Guid qstnId)
        {
            return db.QuestionAndAnswers.Find(qstnId);
        }

        public Test FindTest(Guid testId)
        {
            return db.Tests.Find(testId);
        }

        public IEnumerable<Test> ListTests()
        {
            return db.Tests.ToList();
        }

        
        public List<QuestionAndAnswer> LoadTestQuestions(Guid testId)
        {
            return db.QuestionAndAnswers.Where(t => t.TestId == testId).ToList();
        }

        public async Task<QuestionAndAnswer> UpdateQuestion(QuestionAndAnswer question)
        {
            var questionUpdate = db.QuestionAndAnswers.Update(question);
            questionUpdate.State = EntityState.Modified;
            await db.SaveChangesAsync();
            return question;
        }

        public async Task<Test> UpdateTest(Test test)
        {
            var testUpdate = db.Tests.Update(test);
            testUpdate.State = EntityState.Modified;
            await db.SaveChangesAsync();
            return test;
        }

        public async void AddToTest(string userId, Guid testId)
        {
            var candidate = new CandidateInTest
            {
                CandidateId = userId,
                TestId = testId
            };

            //db.CandidateInTests.AsNoTracking<CandidateInTest>();

            var result = db.CandidateInTests.Add(candidate);
            result.State = EntityState.Added;
            await db.SaveChangesAsync();
        }

        public void RemoveFromTest(string userId, Guid testId)
        {
            var result = db.CandidateInTests.FirstOrDefault(user => user.CandidateId == userId && user.TestId == testId);
            db.CandidateInTests.Remove(result);
            db.SaveChanges();
        }
    }
}
