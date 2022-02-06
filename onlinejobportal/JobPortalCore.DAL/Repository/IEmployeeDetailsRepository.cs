using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalCore.DAL.Repository
{
    public interface IEmployeeDetailsRepository
    {
        void AddCandidateRegister(CandidateRegister candidateRegister);
        void UpdateCandidateRegister(CandidateRegister candidateRegister);
        void DeleteCandidateRegister(int CandidateId);
        CandidateRegister GetCandidateRegisterById(int CandidateId);
        IEnumerable<CandidateRegister> GetCandidateRegister();
        void Register(EmployeeDetails employeeDetails);
        EmployeeDetails Login(EmployeeDetails employee);
      
    }
}
