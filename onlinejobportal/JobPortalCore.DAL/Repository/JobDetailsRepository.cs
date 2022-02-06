using JobPortalCore.DAL.Data;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JobPortalCore.DAL.Repository
{
    public class JobDetailsRepository : IJobDetailsRepository
    {
        JobDbContext _jobDbContext;
        public JobDetailsRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }

        public void AddJob(JobDetails job)
        {
            _jobDbContext.job.Add(job);
            _jobDbContext.SaveChanges();
        }

        public void DeleteJob(int jobid)
        {
            var Job = _jobDbContext.job.Find(jobid);
            _jobDbContext.job.Remove(Job);
            _jobDbContext.SaveChanges();
        }

        public JobDetails GetJobById(int jobid)
        {
            return _jobDbContext.job.Find(jobid);

        }

        public IEnumerable<JobDetails> GetJobs()
        {
            return _jobDbContext.job.ToList();

        }

        public void UpdateJob(JobDetails job)
        {
            _jobDbContext.Entry(job).State = EntityState.Modified;
            _jobDbContext.SaveChanges();
        }
    }
}
        
       



