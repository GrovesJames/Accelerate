using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/schedule")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private IRepository<Schedule> scheduleRepo;
        public ScheduleController(IRepository<Schedule> scheduleRepo)
        {
            this.scheduleRepo = scheduleRepo;
        }

        // GET api/schedule
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            return scheduleRepo.GetAll();
        }

        // GET api/schedule/5
        [HttpGet("{id}")]
        public Schedule Get(int id)
        {
            return scheduleRepo.GetById(id);
        }

        // POST api/schedule
        [HttpPost]
        public IEnumerable<Schedule> Post([FromBody] Schedule schedule)
        {
            scheduleRepo.Create(schedule);
            return scheduleRepo.GetAll();
        }

        // PUT api/schedule/5
        [HttpPut("{id}")]
        public IEnumerable<Schedule> Put(int id, [FromBody] Schedule schedule)
        {
            scheduleRepo.Update(schedule);
            return scheduleRepo.GetAll();
        }

        // DELETE api/schedule/5
        [HttpDelete("{id}")]
        public IEnumerable<Schedule> Delete(int id)
        {
            var schedule = scheduleRepo.GetById(id);
            scheduleRepo.Delete(schedule);
            return scheduleRepo.GetAll();
        }
    }
}
