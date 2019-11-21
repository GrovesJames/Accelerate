using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/activityplans")]
    [ApiController]
    public class ActivityPlanController : ControllerBase
    {

        private IRepository<ActivityPlan> ActivityPlanRepo;

        public ActivityPlanController(IRepository<ActivityPlan> ActivityPlanRepo)
        {
            this.ActivityPlanRepo = ActivityPlanRepo;
        }

        // GET api/ActivityPlans
        [HttpGet]
        public IEnumerable<ActivityPlan> Get()
        {
            return ActivityPlanRepo.GetAll();
        }

        // GET api/ActivityPlans/5
        [HttpGet("{id}")]
        public ActivityPlan Get(int id)
        {
            return ActivityPlanRepo.GetById(id);
        }

        // POST api/ActivityPlans
        [HttpPost]
        public IEnumerable<ActivityPlan> Post([FromBody] ActivityPlan ActivityPlan)
        {
            ActivityPlanRepo.Create(ActivityPlan);
            return ActivityPlanRepo.GetAll();
        }

        // PUT api/ActivityPlans/5
        [HttpPut("{id}")]
        public IEnumerable<ActivityPlan> Put([FromBody] ActivityPlan ActivityPlan)
        {
            ActivityPlanRepo.Update(ActivityPlan);
            return ActivityPlanRepo.GetAll();
        }

        // DELETE api/ActivityPlans/5
        [HttpDelete("{id}")]
        public IEnumerable<ActivityPlan> Delete(int id)
        {
            var ActivityPlan = ActivityPlanRepo.GetById(id);
            ActivityPlanRepo.Delete(ActivityPlan);
            return ActivityPlanRepo.GetAll();
        }
    }
}