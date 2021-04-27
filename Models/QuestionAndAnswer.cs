using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class QuestionAndAnswer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        public string Option1 { get; set; }

        [Required]
        public string Option2 { get; set; }

        [Required]
        public string Option3 { get; set; }

        [Required]
        [Display(Name ="Assigned Score")]
        public int AssignedScore { get; set; }

        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }


        public Guid TestId { get; set; }

        
    }
}
