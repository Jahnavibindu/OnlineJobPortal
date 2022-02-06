using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalCore.Entity.Models
{
    public class CandidateRegister
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Candidate_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public int mobNumber { get; set; }
        public string QualificationDeg { get; set; }
        public string TechnicalSkills { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}
