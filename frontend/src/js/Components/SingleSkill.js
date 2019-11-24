import apiActions from '../apiActions/apiActions'

export default function SingleSkill(skill){
    async function DisplayActivityPlan(skillsActivityPlan){
      let activityPlan = await fetch("https://localhost:44355/api/activityplans/" + skillsActivityPlan.activityPlanId)
      .then(activityplan => activityplan.json())
      .then(activityplan => {return activityplan})

      return `
      <div class="activityDetails" id="activityDetail">
          <input class="activities_id" type="hidden" value="${activityPlan.id}">
          <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
          <h3>${activityPlan.description}</h3>
      </div>    
      `;
    }
    return `
    <div id="detail">
      <article>
        <ul>
          <h3>${skill.name}</h3>
          <h4>${skill.description}</h4>
          <h4>${skill.ageRange}</h4>
        <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
        </ul>
        </article>
        <ul> 
        ${skill.skilsActivityPlans
          .map(skillsActivityPlan => {
            DisplayActivityPlan(skillsActivityPlan);
          })
          .join("")}
        ${skill.milestones
            .map(milestones => {
                return `
                <div class="milestonesDetails" id="milestonesDetail">
                    <input class="milestones_id" type="hidden" value="${milestones.id}">
                    <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
                    <h3>${milestones.milestone}</h3>
                </div>    
                `;
              })
              .join("")}
        </ul>
    </div>
  `;
}