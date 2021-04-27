using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{
    public class AddQuestionViewModel
    {
        [Key]
        public Guid QuestionId { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        [Display(Name = "Correct Answer")]
        public string Answer { get; set; }

        [Required]
        [Display(Name = "Option 1")]
        public string Option1 { get; set; }

        [Required]
        [Display(Name = "Option 2")]
        public string Option2 { get; set; }

        [Required]
        [Display(Name = "Option 3")]
        public string Option3 { get; set; }

        [Required]
        [Display(Name = "Assigned Score")]
        public int AssignedScore { get; set; }

        public Guid TestId { get; set; }
    }
}
