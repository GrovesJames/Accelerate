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

        private IRepository<ActivityPlan> activityPlanRepo;

        public ActivityPlanController(IRepository<ActivityPlan> activityPlanRepo)
        {
            this.activityPlanRepo = activityPlanRepo;
        }

        // GET api/ActivityPlans
        [HttpGet]
        public IEnumerable<ActivityPlan> Get()
        {
            return activityPlanRepo.GetAll();
        }

        // GET api/ActivityPlans/5
        [HttpGet("{id}")]
        public ActivityPlan Get(int id)
        {
            return activityPlanRepo.GetById(id);
        }

        // POST api/ActivityPlans
        [HttpPost]
        public IEnumerable<ActivityPlan> Post([FromBody] ActivityPlan activityPlan)
        {
            activityPlanRepo.Create(activityPlan);
            return activityPlanRepo.GetAll();
        }

        // PUT api/ActivityPlans/5
        [HttpPut("{id}")]
        public IEnumerable<ActivityPlan> Put([FromBody] ActivityPlan activityPlan)
        {
            activityPlanRepo.Update(activityPlan);
            return activityPlanRepo.GetAll();
        }

        // DELETE api/ActivityPlans/5
        [HttpDelete("{id}")]
        public IEnumerable<ActivityPlan> Delete(int id)
        {
            var activityPlan = activityPlanRepo.GetById(id);
            activityPlanRepo.Delete(activityPlan);
            return activityPlanRepo.GetAll();
        }
    }
}