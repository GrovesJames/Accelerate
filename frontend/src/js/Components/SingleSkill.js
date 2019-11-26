
import ActivityPlan from './ActivityPlan'

export default function SingleSkill(skill){
    return `
    <div id="skilldetail">
      <article id="skillsheader">
        <ul id="skill-detail-list">
          <li>
          <div id="skilldesc">
            <h3>${skill.name}</h3>
              <h4>${skill.description}</h4>
            </div>
            <div id="skillpic">
              <img src="${skill.image}"></img>
            </div>
            <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
          </li>
        </ul>
      </article>
      <h5>Milestones</h5>
        <ul id="skillmile"> 
        ${skill.milestones.map(milestones => {
            return `
              <li>
                <div class="milestonesDetails" id="milestonesDetail">
                    <input class="milestones_id" type="hidden" value="${milestones.id}">
                    <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
                    <h4>${milestones.milestone}</h4>
                </div>    
              </li>
            `;
        }).join("")}
        </ul>
    </div>
  `;
}
// ${skill.activityPlans.map( activityPlan => {
//   return `
//     ${ActivityPlan(activityPlan)}
//   `
// }).join("")} 