using ExamPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{
    public class TestDetailViewModel
    {

        public Test Test { get; set; }
        public List<QuestionAndAnswer> QuestionAndAnswers { get; set; }
    }
}
