import Skills from './Skills'
import Calendar from './Calendar'
import Schedule from './Schedule'


export default function Profile(profile) { 

    return `
        <div id="profile-main">
            <h1>${profile.userName}</h1>
        </div>
    `
}