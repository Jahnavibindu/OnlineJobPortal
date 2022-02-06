using JobPortalCore.BAL.Services;
using JobPortalCore.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateRegisterController : ControllerBase
    {
        private CandidateRegisterService _candidateRegisterService;
        public CandidateRegisterController(CandidateRegisterService candidateRegisterService)
        {
            _candidateRegisterService = candidateRegisterService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] CandidateRegister candidateRegister)
        {
            _candidateRegisterService.Register(candidateRegister);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] CandidateRegister candidateRegister)
        {
            CandidateRegister user = _candidateRegisterService.Login(candidateRegister);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }


    }
}
