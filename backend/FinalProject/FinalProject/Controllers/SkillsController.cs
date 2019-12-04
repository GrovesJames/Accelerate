using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
        [Route("api/skills")]
        [ApiController]
        public class SkillsController : ControllerBase
        {
            private IRepository<Skills> SkillsRepo;
            public SkillsController(IRepository<Skills> SkillsRepo)
            {
                this.SkillsRepo = SkillsRepo;
            }
            // GET api/Activitiess
            [HttpGet]
            public IEnumerable<Skills> Get()
            {
                return SkillsRepo.GetAll();
            }
            // GET api/Activitiess/5
            [HttpGet("{id}")]
            public Skills Get(int id)
            {
                return SkillsRepo.GetById(id);
            }
            // POST api/Activitiess
            [HttpPost]
            public IEnumerable<Skills> Post([FromBody] Skills Skills)
            {
                SkillsRepo.Create(Skills);
                return SkillsRepo.GetAll();
            }
            // PUT api/Activitiess/5
            [HttpPut("{id}")]
            public IEnumerable<Skills> Put([FromBody] Skills Skills)
            {
                SkillsRepo.Update(Skills);
                return SkillsRepo.GetAll();
            }
            // DELETE api/Activitiess/5
            [HttpDelete("{id}")]
            public IEnumerable<Skills> Delete(int id)
            {
                var Skills = SkillsRepo.GetById(id);
                SkillsRepo.Delete(Skills);
                return SkillsRepo.GetAll();
            }
        }
}
