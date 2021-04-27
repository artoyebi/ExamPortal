using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class CandidateChoice
    {
        [Key]
        public Guid Id { get; set; }

        public string CandidateId { get; set; }

        public Guid QuestionId { get; set; }

        public string Choice { get; set; }

        public double MarkObtained { get; set; }

    }
}
