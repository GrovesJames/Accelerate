using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ActivitiesController
    {
        private IRepository<Activities> activitiesRepo;
        public ActivitiesController(IRepository<Activities> activitiesRepo)
        {
            this.activitiesRepo = activitiesRepo;
        }

        // GET api/activities
        [HttpGet]
        public IEnumerable<Activities> Get()
        {
            return activitiesRepo.GetAll();
        }

        // GET api/activities/5
        [HttpGet("{id}")]
        public Activities Get(int id)
        {
            return activitiesRepo.GetById(id);
        }

        // POST api/activities
        [HttpPost]
        public IEnumerable<Activities> Post([FromBody] Activities activities)
        {
            activitiesRepo.Create(activities);
            return activitiesRepo.GetAll();
        }

        // PUT api/activities/5
        [HttpPut("{id}")]
        public IEnumerable<Activities> Put(int id, [FromBody] Activities activities)
        {
            activitiesRepo.Update(activities);
            return activitiesRepo.GetAll();
        }

        // DELETE api/activities/5
        [HttpDelete("{id}")]
        public IEnumerable<Activities> Delete(int id)
        {
            var activities = activitiesRepo.GetById(id);
            activitiesRepo.Delete(activities);
            return activitiesRepo.GetAll();
        }
    }
}
