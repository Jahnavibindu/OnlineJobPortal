using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.Entity.Models;

namespace JobPortalCore.DAL.Repository
{
    public interface IJobDetailsRepository
    {
        void AddJob(JobDetails job);
        void UpdateJob(JobDetails job);
        void DeleteJob(int jobid);
        JobDetails GetJobById(int jobid);
        IEnumerable<JobDetails> GetJobs();
    }
}
