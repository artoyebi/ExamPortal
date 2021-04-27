using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public interface ITestRepository
    {
        Task<Test> AddTest(Test test);

        Task<QuestionAndAnswer> AddQuestions(QuestionAndAnswer questionAndAnswer);


        IEnumerable<Test> ListTests();

        Test FindTest(Guid testid);

        List<QuestionAndAnswer> LoadTestQuestions(Guid testId);

        QuestionAndAnswer FindQuestion(Guid qstnId);

        Task<QuestionAndAnswer> UpdateQuestion(QuestionAndAnswer question);

        Task<Test> UpdateTest(Test test);

        void DeleteTest(Test test);

        void DeleteQuestion(QuestionAndAnswer question);

        bool IsCandidateInTest(string userId, Guid testId);

        void AddToTest(string userId, Guid testId);

        void RemoveFromTest(string userId, Guid testId);
    }
}
