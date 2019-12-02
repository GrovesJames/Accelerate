using FinalProject.Controllers;
using FinalProject.Models;
using FinalProject.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace FinalProjectTests
{
    public class ActivityPlanControllerTests
    {
        private ActivityPlanController underTest;
        IRepository<ActivityPlan> activityPlanRepo;

        public ActivityPlanControllerTests()
        {
            activityPlanRepo = Substitute.For<IRepository<ActivityPlan>>();
            underTest = new ActivityPlanController(activityPlanRepo);
        }

        [Fact]
        public void Delete_Removes_ActivityPlan()
        {
            var ActivityPlanID = 1;
            var deletedActivityPlan = new ActivityPlan(1, "title", "agerange", "description", 50, 50,  1);
            var activityPlanList = new List<ActivityPlan>()
            {
                deletedActivityPlan,
                new ActivityPlan(2, "2title", "2agerange", "2description", 250, 250,  2)
            };

            activityPlanRepo.GetById(ActivityPlanID).Returns(deletedActivityPlan);
            activityPlanRepo.When(d => d.Delete(deletedActivityPlan))
                .Do(d => activityPlanList.Remove(deletedActivityPlan));

            activityPlanRepo.GetAll().Returns(activityPlanList);
            var result = underTest.Delete(ActivityPlanID);
            Assert.DoesNotContain(deletedActivityPlan, result);
            //Assert.All(result, item => Assert.Contains("second item", item.Name));

        }
    }
}