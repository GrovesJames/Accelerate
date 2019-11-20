import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Header from './Components/Header'
import Nav from './Components/Nav'

const app = document.getElementById('app');


export default () => {
    pageBuild()
}

function pageBuild(){
    nav()
    header()
    home()
    // scheduleNAV()
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
function schedule(){
    app.innerHTML = Schedule();
}
function scheduleNAV() {
    const navSchedule = document.querySelector('#calendarbtn');
    navSchedule.addEventListener('click', function() {
    });
  }
  

