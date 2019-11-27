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
import SkillActivities from './Components/SkillActivities'
import SingleSkill from './Components/SingleSkill'

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
    updateMilestone()
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
    const skillButtons = document.getElementsByClassName("button-skill");
    for (var i = 0; i < skillButtons.length; i++) {
        skillButtons[i].addEventListener('click', function(){
            const skillId = event.target.value;
            apiActions.getRequest("https://localhost:44355/api/skills/" + skillId, skill => {
                app.innerHTML = SingleSkill(skill);
            })
            document.querySelector('html').style.backgroundImage = 'linear-gradient(rgba(0, 0, 0, 0.705), rgba(0, 0, 0, 0.705)), url("/images/kids.jpg")';
        });
    }
}
function addActivitySelectButtons(){
    const skillButtons = document.getElementsByClassName("button-activities");
    for (var i = 0; i < skillButtons.length; i++) {
        skillButtons[i].addEventListener('click', function(){
            const skillId = event.target.value;
            apiActions.getRequest("https://localhost:44355/api/skills/" + skillId, skill => {
                app.innerHTML = SkillActivities(skill);
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
        addSkillSelectButtons()
        addActivitySelectButtons()
        closeNAV()
        document.querySelector('html').style.backgroundImage = 'linear-gradient(rgba(0, 0, 0, 0.705), rgba(0, 0, 0, 0.705)), url("/images/teacher3.jpg")';
    });
  
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
            const addDate = new Date(document.querySelector('.add-activity_plan').value).toISOString()

            const addActivityPlanTitle = event.target.parentElement.querySelector(
                ".activity-plan_title").value;
            const addActivityPlanDescription = event.target.parentElement.querySelector(
                ".activity-plan_description").value;
            const addActivityPlanScore = event.target.parentElement.querySelector(
                ".activity-plan_score").value;
            const addActitvityPlanDuration = event.target.parentElement.querySelector(
                ".activity-plan_duration").value;
            const scheduleId = 1;
                
            console.log(addDate);
            apiActions.postRequest("https://localhost:44355/api/activities",
             {                
                title: addActivityPlanTitle,
                description: addActivityPlanDescription,
                score: addActivityPlanScore,
                duration: addActitvityPlanDuration,
                activityTime: addDate,
                scheduleId: scheduleId
            },
            activityPlan =>{
            } 
            )        
        }
    });
}
function updateMilestone(){
    app.addEventListener("click", function(){
        if(event.target.classList.contains("milestone_check")){   
            const CheckBoxValue=event.target.value
            let Completed=null;
            if(CheckBoxValue == "on"){Completed=true}
            else {Completed=false};

            const Id= event.target.parentElement.querySelector(
                ".milestones_id").value;
            const Milestone=event.target.parentElement.querySelector(
                ".milestones_milestone").value;
            const AgeRange=event.target.parentElement.querySelector(
                ".milestones_AgeRange" ).value;
            const SkillsId=event.target.parentElement.querySelector(
                ".skill_id").value;
            apiActions.putRequest("https://localhost:44355/api/milestones/" + Id,
            {
                id: Id,
                milestone: Milestone,
                ageRange: AgeRange,
                completed: Completed,
                skillsId: SkillsId
                
            },
            milestone =>{
            } )
        }

    })
}
        
   

