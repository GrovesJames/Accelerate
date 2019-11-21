import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'
import Activities from './Components/Activities'
import Schedules from './Components/Schedules'
import Skills from './Components/Skills'
import About from './Components/About'
import Login from './Components/Login'




const app = document.getElementById('app');

export default () => {
    pageBuild()
}

function pageBuild(){
    nav()
    header()
    home()
    homeNAV()
    calendarNAV()
    skillsNAV()
    aboutNAV()
    loginNAV()
    activitiesNAV()
}


const testSchedule = {
    activities: [{
        title: "Test Activity",
        month: 1,
        day: 3
    },
    { title: "Test Activity 2",
    month: 1,
    day: 5
    }]
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

    Schedule(testSchedule);
}
function skills(){
    app.innerHTML = Skills();
}
function about(){
    app.innerHTML = About();
}
function login(){
    app.innerHTML = Login();
}
    apiActions.getRequest("https://localhost:44355/api/schedules/1", schedule => {
        Schedule(schedule);
    })
// Navigation functions
function homeNAV() {
    const navHome = document.querySelector('#homenav');
    navHome.addEventListener('click', function() {
        window.location.reload()
    });
  }
function calendarNAV() {
    const navSchedule = document.querySelector('#calendarnav');
    navSchedule.addEventListener('click', function() {
        calendar()
        closeNAV()
    });
}
function skillsNAV() {
    const navSkills = document.querySelector('#skillsnav');
    navSkills.addEventListener('click', function() {
        skills()
        closeNAV()
    });
}
function activitiesNAV() {
    const navActivities = document.querySelector('#activitiesnav');    
    navActivities.addEventListener('click', function() {
        apiActions.getRequest("https://localhost:44355/api/activities", activities => {
            document.querySelector('#app').innerHTML = Activities(activities);
            console.log(activities);
            closeNAV()
        });
    });

    const app = document.querySelector('#app');
    app.addEventListener('click', function() {
        if(event.target.classList.contains('add_activity_submit')) {
           
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
function aboutNAV() {
    const navAbout = document.querySelector('#btn1');
    navAbout.addEventListener('click', function() {
        about()
        closeNAV()
        document.querySelector('html').style.backgroundImage = 'linear-gradient(rgba(0, 0, 0, 0.705), rgba(0, 0, 0, 0.705)), url("/images/teacher2.jpg")';
    });
}
function loginNAV() {
    const navLogin = document.querySelector('#btn2');
    navLogin.addEventListener('click', function() {
        login()
        closeNAV()
    });
}
function closeNAV(){
    document.getElementById('closeNAV').checked = false;
}
