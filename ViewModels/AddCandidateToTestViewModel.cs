using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{
    public class AddCandidateToTestViewModel
    {
        //public string TestDescription { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string CandidateId { get; set; }

        public bool IsSelected { get; set; }
    }
}
