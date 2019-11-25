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
import Profile from './Components/Profile'
import SingleActivityPlan from './Components/SingleActivityPlan'
import SingleSkill from './Components/SingleSkill'
import SingleSkillActivityPlans from './Components/SingleSkillActivityPlans'

const app = document.getElementById('app');
const Testprofile = {
    userName : "TestUser"
};
apiActions.getRequest("https://localhost:44355/api/schedules/1", schedule => {
    Testprofile.schedule = schedule;
})

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
    stampDate()
    profileNAV()
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
function calendar(divPopulate){
    divPopulate.innerHTML = Calendar();
    apiActions.getRequest("https://localhost:44355/api/schedules/1", schedule => {
        Schedule(schedule);
    })
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
function addSkillSelectButtons(){
    const skillButtons = document.getElementsByClassName("button-profile-skill");
    for (var i = 0; i < skillButtons.length; i++) {
        skillButtons[i].addEventListener('click', function(){
            const skillId = event.target.value;
            apiActions.getRequest("https://localhost:44355/api/skills/" + skillId, skill => {
                app.innerHTML = SingleSkill(skill);
            })
        });
    }
}
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
        calendar(app)
        closeNAV()
    });
}
function skillsNAV() {
    const navSkills = document.querySelector('#skillsnav');
    navSkills.addEventListener('click', function() {
        skills()
        closeNAV()
        document.querySelector('html').style.backgroundImage = 'linear-gradient(rgba(0, 0, 0, 0.705), rgba(0, 0, 0, 0.705)), url("/images/teacher3.jpg")';
    });
    app.addEventListener('click', function(){
        if(event.target.classList.contains("acitvityDetails")){
            const activityPlanID = event.target.parentElement.querySelector(".activities_id")
            .value;
            apiActions.getRequest(`https://localhost:44355/api/activityplans/${activityPlanID}`,
            activityPlanID => {
                console.log(activites.name)
                
               document.querySelector("#app").innerHTML = SingleActivityPlan(activityPlan);

               
             })
        }
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
        console.log("delete " + activityId);
        apiActions.deleteRequest(`https://localhost:44330/api/activities/${activityId}`,
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
function profileNAV(){
    const navProfile = document.querySelector('#profilenav');
    navProfile.addEventListener('click', function() {
        apiActions.getRequest("https://localhost:44355/api/profile/1", profile => {
            app.innerHTML = Profile(profile);
            addSkillSelectButtons();
            calendar(document.getElementById("profile-calendar"));
        });
        closeNAV()
    });
}
function closeNAV(){
    document.getElementById('closeNAV').checked = false;
}

function stampDate(){
    app.addEventListener("click", function(){
        if(event.target.classList.contains("activity-plan_submit")){   
            const addActionPlan = new Date(document.querySelector('.add-activity_plan').value).toISOString()

            const addActivityPlanDescription = event.target.parentElement.querySelector(
                "activity-plan_description").value;
            const addActivityPlanScore = event.target.parentElement.querySelector(
                "activity-plan_score").value;
            const addActitvityPlanDuration = event.target.parentElement.querySelector(
                "activity-plan_duration").value;
                
            console.log(addActivityPlan);
            apiActions.postRequest("https://localhost:44355/api/activities",
             {                
                description: addActivityPlanDescription,
                score: addActivityPlanScore,
                duration: addActitvityPlanDuration,
                activityTime: addActionPlan
            },
            activityPlan =>{
                console.log(activityPlan);
                document.querySelector("#app").innerHTML = ActivityPlan(activityPlan);
            } 
            )        
        }
    });
}
        
   

