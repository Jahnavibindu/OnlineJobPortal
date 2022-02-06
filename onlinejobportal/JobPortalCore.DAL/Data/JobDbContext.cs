using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.Entity.Models;

namespace JobPortalCore.DAL.Data
{
    public class JobDbContext : DbContext
    {
        

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {

        }
        public DbSet<JobDetails> job { get; set; }
        public DbSet<CandidateRegister> candidateRegister { get; set; }
        public DbSet<EmployeeDetails> employeeDetails { get; set; }
    }
}
