using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalCore.Entity.Models
{
    public class JobDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Jobid { get; set; }
        public EmployeeDetails employeeDetails { get; set; }
        [ForeignKey("employeeDetails")]
        public CandidateRegister candidateRegister { get; set; }
        [ForeignKey("candidateRegister")]
        public string Jobtitle { get; set; }
        public string Joblocation { get; set; }
        public string Technicalskills { get; set; }
        public string Qualification { get; set; }
        public string Companyname { get; set; }
        public string Contactperson { get; set; }
        public int Contactnumber { get; set; }
    }
}
