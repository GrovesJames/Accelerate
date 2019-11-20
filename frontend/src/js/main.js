import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'
import Header from './Components/Header'
import Nav from './Components/Nav'


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
    calendar()
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
    calendardiv.innerHTML = Calendar();
    Schedule();
}
function scheduleNAV() {
    const navSchedule = document.querySelector('#calendarbtn');
    navSchedule.addEventListener('click', function() {
    });
  }
  

