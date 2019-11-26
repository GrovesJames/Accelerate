import Skills from './Skills'
import Calendar from './Calendar'
import Schedule from './Schedule'


export default function Profile(profile) { 

    return `
        <div id="profile-main">
            <h1>${profile.userName}</h1>
        </div>
        <div id="profile-skills">
            <button value="1" class="button-profile-skill">Speech</button>
            <button value="2" class="button-profile-skill">Cognitive Functionality</button>
            <button value="3" class="button-profile-skill">Motor Skills</button>
        </div>
        <div id="profile-calendar"></div>
    `
}