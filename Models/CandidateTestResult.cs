using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class CandidateTestResult
    {
        public Guid Id { get; set; }

        public string CandidateId { get; set; }

        public Guid TestId { get; set; }

        public double TotalScore { get; set; }

        public List<CandidateChoice> Choices { get; set; }
    }
}
