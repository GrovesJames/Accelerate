using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/milestones")]
    [ApiController]
    public class MilestonesController : ControllerBase
    {

        private IRepository<Milestones> milestonesRepo;

        public MilestonesController(IRepository<Milestones> milestonesRepo)
        {
            this.milestonesRepo = milestonesRepo;
        }

        // GET api/Milestones
        [HttpGet]
        public IEnumerable<Milestones> Get()
        {
            return milestonesRepo.GetAll();
        }

        // GET api/Milestones/5
        [HttpGet("{id}")]
        public Milestones Get(int id)
        {
            return milestonesRepo.GetById(id);
        }

        // POST api/Milestones
        [HttpPost]
        public IEnumerable<Milestones> Post([FromBody] Milestones milestones)
        {
            milestonesRepo.Create(milestones);
            return milestonesRepo.GetAll();
        }

        // PUT api/Milestones/5
        [HttpPut("{id}")]
        public IEnumerable<Milestones> Put([FromBody] Milestones milestones)
        {
            milestonesRepo.Update(milestones);
            return milestonesRepo.GetAll();
        }

        // DELETE api/Milestones/5
        [HttpDelete("{id}")]
        public IEnumerable<Milestones> Delete(int id)
        {
            var milestones = milestonesRepo.GetById(id);
            milestonesRepo.Delete(milestones);
            return milestonesRepo.GetAll();
        }
        [HttpGet("completed")]
        public IEnumerable<Milestones> GetDone()
        {
            return milestonesRepo.GetByCompleted();
        }
        //Get api/activities/notdone
        [HttpGet("notcompleted")]
        public IEnumerable<Milestones> GetNotDone()
        {
            return milestonesRepo.GetByNotCompleted();
        }
    }
}
