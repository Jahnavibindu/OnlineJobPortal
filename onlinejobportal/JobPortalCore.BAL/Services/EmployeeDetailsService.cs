using System;
using System.Collections.Generic;
using System.Text;
using JobPortalCore.DAL.Repository;
using JobPortalCore.Entity.Models;

namespace JobPortalCore.BAL.Services
{
    public class EmployeeDetailsService
    {
        IEmployeeDetailsRepository _EmployeeDetailsRepository;
        public EmployeeDetailsService(IEmployeeDetailsRepository employeeDetailsRepository)
        {
            _EmployeeDetailsRepository = employeeDetailsRepository;

        }
        public void AddCandidateRegister(CandidateRegister candidateRegister)
        {
            _EmployeeDetailsRepository.AddCandidateRegister(candidateRegister);
        }
        public void UpdateCandidateRegister(CandidateRegister candidateRegister)
        {
            _EmployeeDetailsRepository.UpdateCandidateRegister(candidateRegister);
        }
        public void DeleteEmployee(int CandidateId)
        {
            _EmployeeDetailsRepository.DeleteCandidateRegister(CandidateId);
        }
        public CandidateRegister GetCandidateRegisterByID(int CandidateId)
        {
            return _EmployeeDetailsRepository.GetCandidateRegisterById(CandidateId);

        }
        public IEnumerable<CandidateRegister> GetCandidateRegister()
        {
            return _EmployeeDetailsRepository.GetCandidateRegister();
        }

        public void Register(EmployeeDetails employeeDetails)
        {
            _EmployeeDetailsRepository.Register(employeeDetails);
        }

        public EmployeeDetails Login(EmployeeDetails employee)
        {
            return _EmployeeDetailsRepository.Login(employee);
        }


    }
}
