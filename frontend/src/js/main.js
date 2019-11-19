import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'
import Calendar from './Components/Calendar'

const app = document.getElementById('app');
const calendardiv = document.getElementById('calendar');

export default () => {
    pageBuild()
}

function pageBuild(){
    home()
    scheduleNAV()
    calendar()
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
  

