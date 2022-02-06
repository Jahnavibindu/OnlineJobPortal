using JobPortalCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalCore.DAL.Repository
{
    public interface ICandidateRegisterRepository
    {
        void Register(CandidateRegister candidateRegister);
        CandidateRegister Login(CandidateRegister candidate);
    }
}
