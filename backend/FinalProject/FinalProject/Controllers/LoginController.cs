using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IRepository<Login> loginRepo;

        public LoginController(IRepository<Login> loginRepo)
        {
            this.loginRepo = loginRepo;
        }

        // GET api/Login
        [HttpGet]
        public IEnumerable<Login> Get()
        {
            return loginRepo.GetAll();
        }

        // GET api/Login/5
        [HttpGet("{id}")]
        public Login Get(int id)
        {
            return loginRepo.GetById(id);
        }

        // POST api/Login
        [HttpPost]
        public IEnumerable<Login> Post([FromBody] Login login)
        {
            loginRepo.Create(login);
            return loginRepo.GetAll();
        }

        // PUT api/Login/5
        [HttpPut("{id}")]
        public IEnumerable<Login> Put([FromBody] Login login)
        {
            loginRepo.Update(login);
            return loginRepo.GetAll();
        }

        // DELETE api/Login/5
        [HttpDelete("{id}")]
        public IEnumerable<Login> Delete(int id)
        {
            var login = loginRepo.GetById(id);
            loginRepo.Delete(login);
            return loginRepo.GetAll();
        }
    }
}
