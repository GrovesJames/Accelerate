import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'
import Activities from './Components/Activities'
import Schedules from './Components/Schedules'


const app = document.getElementById('app');
const calendardiv = document.getElementById('calendar');

export default () => {
    pageBuild()
}

function pageBuild(){
    nav()
    header()
    home()
    scheduleNAV()
    // calendar()
    displayActivities()
}

function nav(){
    const nav = document.getElementById('nav')
    nav.innerHTML = Nav();
}
function header(){
    const header = document.getElementById('header')
    header.innerHTML = Header();
}
function home(){
    app.innerHTML = Home();
}
function calendar(){
    app.innerHTML = Calendar();
    Schedule();
}
function scheduleNAV() {
    const navSchedule = document.querySelector('#calendarnav');
    navSchedule.addEventListener('click', function() {
        calendar()
    });
}
function displayActivities() {
    const navActivities = document.querySelector('#activitiesnav');    
    navActivities.addEventListener('click', function() {
        apiActions.getRequest("https://localhost:44355/api/activities", activities => {
            document.querySelector('#app').innerHTML = Activities(activities);
            console.log(activities);
        });
    });

    const app = document.querySelector('#app');
    app.addEventListener('click', function() {
        if(event.target.classList.contains('add_activity_submit')) {
            const addActivity = event.target.parentElement.querySelector(
                ".add_activity_title",
            ).value;
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
            const activity = {
                title: addActivity,
          ageRange: activityAgeRange,
          description: activityDescription,
          duration: activityDuration,
          score: activityScore,
          scheduleId: scheduleId
            } 

            console.log(activity);
          apiActions.postRequest("https://localhost:44355/api/activities",
            activity, 
        activities => {
          console.log(activities);
          document.querySelector("#app").innerHTML = Activities(activities);
        })       
    }
})

app.addEventListener('click', function() {
    if(event.target.classList.contains("delete_activity_submit")) {
        const activityId = event.target.parentElement.querySelector(".activity_id")
            .value;
        console.log("delete " + scientistId);
        apiActions.deleteRequest(`https://localhost:44330/api/scientist/${scientistId}`,
        activities =>{
           document.querySelector("#app").innerHTML = Activities(activities)
        })
    }
})


}

  
  

