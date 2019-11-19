using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/schedules")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {

        private IRepository<Schedule> ScheduleRepo;

        public ScheduleController(IRepository<Schedule> ScheduleRepo)
        {
            this.ScheduleRepo = ScheduleRepo;
        }

        // GET api/Schedules
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            return ScheduleRepo.GetAll();
        }

        // GET api/Schedules/5
        [HttpGet("{id}")]
        public Schedule Get(int id)
        {
            return ScheduleRepo.GetById(id);
        }

        // POST api/Schedules
        [HttpPost]
        public IEnumerable<Schedule> Post([FromBody] Schedule Schedule)
        {
            ScheduleRepo.Create(Schedule);
            return ScheduleRepo.GetAll();
        }

        // PUT api/Schedules/5
        [HttpPut("{id}")]
        public IEnumerable<Schedule> Put([FromBody] Schedule Schedule)
        {
            ScheduleRepo.Update(Schedule);
            return ScheduleRepo.GetAll();
        }

        // DELETE api/Schedules/5
        [HttpDelete("{id}")]
        public IEnumerable<Schedule> Delete(int id)
        {
            var Schedule = ScheduleRepo.GetById(id);
            ScheduleRepo.Delete(Schedule);
            return ScheduleRepo.GetAll();
        }
    }
}
