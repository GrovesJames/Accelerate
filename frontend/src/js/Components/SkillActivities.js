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
      <h5>Activites</h5>
        <ul id="skillactivities"> 
        ${skill.activityPlans.map( activityPlan => {
          return `
            ${ActivityPlan(activityPlan)}
          `
        }).join("")}
        </ul>
    </div>
  `;
}