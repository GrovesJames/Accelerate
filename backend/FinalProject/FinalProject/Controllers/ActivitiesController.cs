using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/activities")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private IRepository<Activities> ActivitiesRepo;
        public ActivitiesController(IRepository<Activities> ActivitiesRepo)
        {
            this.ActivitiesRepo = ActivitiesRepo;
        }
        // GET api/Activitiess
        [HttpGet]
        public IEnumerable<Activities> Get()
        {
            return ActivitiesRepo.GetAll();
        }
        // GET api/Activitiess/5
        [HttpGet("{id}")]
        public Activities Get(int id)
        {
            return ActivitiesRepo.GetById(id);
        }
        // POST api/Activitiess
        [HttpPost]
        public IEnumerable<Activities> Post([FromBody] Activities Activities)
        {
            ActivitiesRepo.Create(Activities);
            return ActivitiesRepo.GetAll();
        }
        // PUT api/Activitiess/5
        [HttpPut("{id}")]
        public IEnumerable<Activities> Put([FromBody] Activities Activities)
        {
            ActivitiesRepo.Update(Activities);
            return ActivitiesRepo.GetAll();
        }
        // DELETE api/Activitiess/5
        [HttpDelete("{id}")]
        public IEnumerable<Activities> Delete(int id)
        {
            var Activities = ActivitiesRepo.GetById(id);
            ActivitiesRepo.Delete(Activities);
            return ActivitiesRepo.GetAll();
        }
    }
}
