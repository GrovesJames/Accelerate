using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace FinalProject.Controllers
{
    [Route("api/skillsactivityplans")]
    [ApiController]
    public class SkillsActivityPlanController : ControllerBase
    {

        private IRepository<SkillsActivityPlan> SkillsActivityPlanRepo;

        public SkillsActivityPlanController(IRepository<SkillsActivityPlan> SkillsActivityPlanRepo)
        {
            this.SkillsActivityPlanRepo = SkillsActivityPlanRepo;
        }

        // GET api/SkillsActivityPlans
        [HttpGet]
        public IEnumerable<SkillsActivityPlan> Get()
        {
            return SkillsActivityPlanRepo.GetAll();
        }

        // GET api/SkillsActivityPlans/5
        [HttpGet("{id}")]
        public SkillsActivityPlan Get(int id)
        {
            return SkillsActivityPlanRepo.GetById(id);
        }

        // POST api/SkillsActivityPlans
        [HttpPost]
        public IEnumerable<SkillsActivityPlan> Post([FromBody] SkillsActivityPlan SkillsActivityPlan)
        {
            SkillsActivityPlanRepo.Create(SkillsActivityPlan);
            return SkillsActivityPlanRepo.GetAll();
        }

        // PUT api/SkillsActivityPlans/5
        [HttpPut("{id}")]
        public IEnumerable<SkillsActivityPlan> Put([FromBody] SkillsActivityPlan SkillsActivityPlan)
        {
            SkillsActivityPlanRepo.Update(SkillsActivityPlan);
            return SkillsActivityPlanRepo.GetAll();
        }

        // DELETE api/SkillsActivityPlans/5
        [HttpDelete("{id}")]
        public IEnumerable<SkillsActivityPlan> Delete(int id)
        {
            var SkillsActivityPlan = SkillsActivityPlanRepo.GetById(id);
            SkillsActivityPlanRepo.Delete(SkillsActivityPlan);
            return SkillsActivityPlanRepo.GetAll();
        }
    }
}
