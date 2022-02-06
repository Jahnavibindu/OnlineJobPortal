using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.DAL.Repository;
using JobPortalCore.Entity.Models;


namespace JobPortalCore.BAL.Services
{
    public class JobDetailsService
    {
        IJobDetailsRepository _jobRepository;
        public JobDetailsService(IJobDetailsRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        
        public void AddJob(JobDetails job)
        {
            _jobRepository.AddJob(job);
        }
        
        public void UpdateJob(JobDetails job)
        {
            _jobRepository.UpdateJob(job);
        }
        
        public void DeleteJob(int jobid)
        {
            _jobRepository.DeleteJob(jobid);
        }
        
        public void GetJobById(int jobid)
        {
            _jobRepository.GetJobById(jobid);
        }
        
        public void GetJob()
        {
            _jobRepository.GetJobs();
        }
    }
}

    

