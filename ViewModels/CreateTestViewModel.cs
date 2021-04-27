using ExamPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{

    
    public class CreateTestViewModel
    {
        

        [Key]
        public Guid TestId { get; set; }


        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Instruction(s)")]
        public string Instruction { get; set; }

        [Required]
        [Display(Name ="Created By")]
        public string CreatedBy { get; set; }

        [Required]
        [Display(Name ="Duration(mins)")]
        public string Duration { get; set; }

        [Required]
        [Display(Name = "Available From")]
        public DateTime AvailableFrom { get; set; }

        [Required]
        [Display(Name = "Available Till")]
        public DateTime AvailableTill { get; set; }

        

        
    }
}
