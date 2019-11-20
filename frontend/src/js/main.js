import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'
import Day from './Components/Day'


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
    homeNAV()
    dayNAV()
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
function day(){
    app.innerHTML = Day();
}

// Navigation functions
function dayNAV() {
    const navDay = document.querySelector('#calendar-day');
    navDay.addEventListener('click', function() {
        day()
    });
  }
function homeNAV() {
    const navHome = document.querySelector('#homenav');
    navHome.addEventListener('click', function() {
        home()
        closeNAV()
    });
  }
function scheduleNAV() {
    const navSchedule = document.querySelector('#calendarnav');
    navSchedule.addEventListener('click', function() {
        calendar()
        closeNAV()
    });
  }
function closeNAV(){
    document.getElementById('closeNAV').checked = false;
}

