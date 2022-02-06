using JobPortalCore.DAL.Repository;
using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalCore.BAL.Services
{
   public  class CandidateRegisterService
    {
        private ICandidateRegisterRepository _candidateRegisterRepository;
        public CandidateRegisterService(ICandidateRegisterRepository candidateRegisterRepository)
        {
            _candidateRegisterRepository = candidateRegisterRepository;
        }

        public void Register(CandidateRegister candidateRegister)
        {
            _candidateRegisterRepository.Register(candidateRegister);
        }
        public CandidateRegister Login(CandidateRegister candidateRegister)
        {
            return _candidateRegisterRepository.Login(candidateRegister);
        }
    }
}
