using FinalProject.Controllers;
using FinalProject.Models;
using FinalProject.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Post_Creates_New_ActivityPlan()
        {
            var newActivityPlan = new ActivityPlan(1, "title", "agerange", "description", 50, 50, 1);
            var ActivityPlanList = new List<ActivityPlan>();

            activityPlanRepo.When(t => t.Create(newActivityPlan))
                .Do(t => ActivityPlanList.Add(newActivityPlan));

            activityPlanRepo.GetAll().Returns(ActivityPlanList);

            var result = underTest.Post(newActivityPlan);

            Assert.Contains(newActivityPlan, result);
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
            //Assert.All(result, item => Assert.Contains("second item", item.Title));

        }
        [Fact]
        public void Put_Updates_ActivityPlan()
        {
            var originalActivityPlan = new ActivityPlan(1, "title", "agerange", "description", 50, 50, 1);
            var expectedActivityPlan = new List<ActivityPlan>()
            {
                originalActivityPlan
            };
            var updatedActivityPlan = new ActivityPlan(1, "2title", "2agerange", "2description", 250, 250, 1);

            activityPlanRepo.When(t => activityPlanRepo.Update(updatedActivityPlan))
                .Do(Callback.First(t => expectedActivityPlan.Remove(originalActivityPlan))
                .Then(t => expectedActivityPlan.Add(updatedActivityPlan)));
            activityPlanRepo.GetAll().Returns(expectedActivityPlan);

            var result = underTest.Put(updatedActivityPlan);

            Assert.Equal(expectedActivityPlan, result.ToList());
           
        }
    }
}