import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'
import Activities from './Components/Activities'
import EditActivity from './Components/EditActivity'
import ActivityPlan from './Components/ActivityPlan'
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
    addActivityPlan()
    updateMilestone()
    stampDate()
    DeleteActivity()
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
    apiActions.getRequest("https://localhost:44355/api/skills", skills => {
        app.innerHTML = Skills(skills);
        addSkillSelectButtons()
        addActivitySelectButtons()
    })
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
            const addDate = new Date(event.target.parentElement.querySelector('.add-activity_plan').value).toISOString()

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
                alert("you have added " + addActivityPlanTitle + " to your schedule");
            })        
        }
    });
}

   function addActivityPlan(){
    app.addEventListener('click', function() {
        if(event.target.classList.contains('add_activity-plan_submit')) {
            const activityplanTitle = event.target.parentElement.querySelector(
                ".add-activity-plan_title",
            ).value;
            const activityplanDescription = event.target.parentElement.querySelector(
                ".add-activity-plan_description",
            ).value;
            const activityplanScore = event.target.parentElement.querySelector(
                ".add-activty-plan_score",
            ).value;
            const activityplanDuration = event.target.parentElement.querySelector(
                ".add-activty-plan_duration",
            ).value;
            const skillsId = event.target.parentElement.querySelector(
                ".add-skills-id",
            ).value;
            const activityPlan = {
                
                title: activityplanTitle,
                ageRange: "3-5",
                description: activityplanDescription,
                duration: activityplanDuration,
                score: activityplanScore,   
                skillsId: skillsId           
                  } 

            console.log(activityPlan);
            apiActions.postRequest("https://localhost:44355/api/activityplans",
            activityPlan, 
            activityPlan => {
            alert("You added a new activity!")
        })       
    }
})
    app.addEventListener('click', function() {
         if(event.target.classList.contains("delete_activity_submit")) {
            const activityPlanId = event.target.parentElement.querySelector(".activityPlan.id")
            .value;
            console.log("delete" + activityPlanId);
         apiActions.deleteRequest(`https://localhost:44355/api/activityplans/${activityPlanId}`,
         activityPlan, 
         activityPlan => {
         alert("You deleted an activity!")
        })
    }
})


}  

function DeleteActivity(){
    app.addEventListener("click", function(){
        if(event.target.classList.contains("activity-delete-btn")){
            const activityId = event.target.parentElement.querySelector(".activity-plan-id").value;
            apiActions.deleteRequest("https://localhost:44355/api/activityplans/" + activityId, function(){
                alert("The Activity has been Deleted");
            })
        }
    })
};

function updateMilestone(){
    app.addEventListener("click", function(){
        if(event.target.classList.contains("milestone_check")){   
            let Completed = null;
            const completed= event.target.parentElement.parentElement.querySelector(
                ".milestones_checked").value;
            if(completed == "true"){Completed=false}
            else {Completed=true};

            const Id= event.target.parentElement.parentElement.querySelector(
                ".milestones_id").value;
            const Milestone=event.target.parentElement.parentElement.querySelector(
                ".milestones_milestone").value;
            const AgeRange=event.target.parentElement.parentElement.querySelector(
                ".milestones_AgeRange" ).value;
            const SkillsId=event.target.parentElement.parentElement.querySelector(
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

        

   

