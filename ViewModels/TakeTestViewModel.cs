using ExamPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{
    public class TakeTestViewModel
    {
      

        public Test Test { get; set; }

        public IEnumerable<QuestionAndAnswer> Questions { get; set; }

        public List<FlaggedQuestion> FlaggedQuestions { get; set; }

        public string Choice { get; set; }

        public List<CandidateChoice> CandidateChoices { get; set; }

        public CandidateTestResult CandidateTestResult { get; set; }

        public int PageCount { get; set; }


    }
}
