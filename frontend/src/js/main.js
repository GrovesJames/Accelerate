import apiActions from './apiActions/apiActions'
import Home from './Components/Home'
import Schedule from './Components/Schedule'

const app = document.getElementById('app');


export default () => {
    pageBuild()
}

function pageBuild(){
    home()
    scheduleNAV()
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
  

