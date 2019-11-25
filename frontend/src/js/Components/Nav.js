export default function Nav() {
    return `
    <div class="menu-wrap">
    <input type="checkbox" id="closeNAV" class="toggler">
    <div class="hamburger"><div></div></div>
    <div class="menu">
      <div>
        <div>
          <ul>
            <li><a id="homenav"><strong>Home</strong></a></li>
            <li><a id="calendarnav"><strong>Calendar</strong></a></li>
            <li><a id="skillsnav"><strong>Skills</strong></a></li>
            <li><a id="activitiesnav"><strong>Activities</strong></a></li>
            <li><a id="profilenav"><strong>Profile</strong></a></li>
            </ul>
        </div>
      </div> 
    </div>
  </div>
    `
}