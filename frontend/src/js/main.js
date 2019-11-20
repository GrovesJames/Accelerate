import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'
import Activities from './Components/Activities'


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
    activitiesNAV()
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
function activitiesNAV() {
    const navActivities = document.querySelector('#activitiesnav');    
    navActivities.addEventListener('click', function() {
        apiActions.getRequest("https://localhost:44355/api/activities", activities => {
            document.querySelector('#app').innerHTML = Activities(activities);
            console.log(activities);
        })
    })
}

  
  

