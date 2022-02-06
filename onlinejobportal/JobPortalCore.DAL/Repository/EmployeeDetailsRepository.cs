using JobPortalCore.DAL.Data;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JobPortalCore.DAL.Repository
{
    public class EmployeeDetailsRepository : IEmployeeDetailsRepository
    {
        JobDbContext _jobDbContext;
        public EmployeeDetailsRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }

        public object[] CandidateId { get; private set; }


        public void AddCandidateRegister(CandidateRegister candidateRegister)
        {
            _jobDbContext.candidateRegister.Add(candidateRegister);
            _jobDbContext.SaveChanges();
        }

        public void DeleteCandidateRegister(int CandidateId)
        {
            var candidateRegister = _jobDbContext.candidateRegister.Find(CandidateId);
            _jobDbContext.candidateRegister.Remove(candidateRegister);
            _jobDbContext.SaveChanges();
        }

        public IEnumerable<CandidateRegister> GetCandidateRegister()
        {
            return _jobDbContext.candidateRegister.ToList();

        }

        public CandidateRegister GetCandidateRegisterById(int CandidateId)
        {
            return _jobDbContext.candidateRegister.Find(CandidateId);

        }

        public EmployeeDetails Login(EmployeeDetails employee)
        {
            EmployeeDetails employeeDetails = null;
            var result = _jobDbContext.employeeDetails.Where(obj => obj.EmailId == employee.EmailId && obj.Password == employee.Password).ToList();
            if (result.Count > 0)
            {
                employeeDetails = result[0];
            }
            return employeeDetails;
        }

        public void Register(EmployeeDetails employeeDetails)
        {
            _jobDbContext.employeeDetails.Add(employeeDetails);
            _jobDbContext.SaveChanges();
        }

        public void UpdateCandidateRegister(CandidateRegister candidateRegister)
        {
            _jobDbContext.Entry(candidateRegister).State = EntityState.Modified;
            _jobDbContext.SaveChanges();
        }
    }
}