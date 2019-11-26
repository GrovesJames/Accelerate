import Activities from './Components/Activities'
import EditActivity from './Components/EditActivity'
import apiActions from './api/apiActions'


export default () => {
    displayActivities()
}

function displayActivities(){
    const activitiesButton = document.querySelector("#activitiesnav");
    activitiesButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44355/api/activities", activities => {
            document.querySelector("#app").innerHTML = Activities(activities);
            console.log(albums);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if (event.target.classList.contains('add_activity_submit')) {
            const activityAgeRange = event.target.parentElement.querySelector(
                ".add_activity_ageRange",
            ).value;
            const activityDescription = event.target.parentElement.querySelector(
              ".add_activity_description",
            ).value;
              const activityDuration = event.target.parentElement.querySelector(
                  ".add_activity_duration",
            ).value;
              const activityScore = event.target.parentElement.querySelector(
                  ".add_activity_score",
            ).value; 
            const scheduleId = event.target.parentElement.querySelector(".schedule_id") 
            .value; 
            console.log(addActivity);
            apiActions.postRequest("https://localhost:44355/api/activities",
             {
                ageRange: activityAgeRange,
                description: activityDescription,
                duration: activityDuration,
                score: activityScore,
                scheduleId: scheduleId
            },
            activities => {
                console.log(activities);
                document.querySelector("#app").innerHTML = Activities(activities);
            }                    
            )
    }
}); 

app.addEventListener("click", function() {
    if(event.target.classList.contains("delete_activity_submit")) {
        const activityId = event.target.parentElement.querySelector(".activity_id").value;
        console.log("delete" + activityId);
        apiActions.deleteRequest(`https://localhost:44355/api/activities/${activityId}`,
            activities => {
                app.innerHTML = Activities(activities);
            })       
    }
});
}