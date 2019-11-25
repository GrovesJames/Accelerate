using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
   
        [Route("api/profile")]

        [ApiController]
        public class ProfileController : ControllerBase
        {

            private IRepository<Profile> ProfileRepo;

            public ProfileController(IRepository<Profile> ProfileRepo)
            {
                this.ProfileRepo = ProfileRepo;
            }

            // GET api/Profile
            [HttpGet]
            public IEnumerable<Profile> Get()
            {
                return ProfileRepo.GetAll();
            }

            // GET api/Profile/5
            [HttpGet("{id}")]
            public Profile Get(int id)
            {
                return ProfileRepo.GetById(id);
            }

            // POST api/Profile
            [HttpPost]
            public IEnumerable<Profile> Post([FromBody] Profile Profile)
            {
                ProfileRepo.Create(Profile);
                return ProfileRepo.GetAll();
            }

            // PUT api/Profile/5
            [HttpPut("{id}")]
            public IEnumerable<Profile> Put([FromBody] Profile Profile)
            {
                ProfileRepo.Update(Profile);
                return ProfileRepo.GetAll();
            }

            // DELETE api/Profile/5
            [HttpDelete("{id}")]
            public IEnumerable<Profile> Delete(int id)
            {
                var Profile = ProfileRepo.GetById(id);
                ProfileRepo.Delete(Profile);
                return ProfileRepo.GetAll();
            }
        }
    }


