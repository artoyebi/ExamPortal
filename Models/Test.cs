using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class Test
    {
        public Test()
        {
            Questions = new List<QuestionAndAnswer>();
        }

        [Key]
        public Guid Id { get; set; }


        [Required]
        [MaxLength(15)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Instruction(s)")]
        public string Instruction { get; set; }

        [Required]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; } 

        [Required]
        [Display(Name = "Duration of Test(mins)")]
        public string Duration { get; set; }

        [Required]
        [Display(Name = "Available From")]
        public DateTime AvailableFrom { get; set; }

        [Required]
        [Display(Name = "Available Till")]
        public DateTime AvailableTill { get; set; }

        public List<QuestionAndAnswer> Questions { get; set; }

    }
}
