using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    //[Keyless]
    public class CandidateInTest
    {
        [Key]
        [Column(Order = 1)]
        public Guid Id { get; set; }

        public string CandidateId { get; set; }

        public Guid TestId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual ApplicationUser UserInCandidateRole { get; set; }

        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
    }
}
