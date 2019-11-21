export default function SingleSkill(skills){
    return`
    <div id="detail">
      <article>
        <ul>
          <h3>${skills.name}</h3>
          <h4>${skills.description}</h4>
          <h4>${skills.ageRange}</h4>
        <input id="skillid" class="skill_id" type="hidden" value="${skills.id}">
        </ul>
        </article>
        <ul> 
        ${skills.activities
          .map(activities => {
            return `
            <div class="activityDetails" id="activityDetail">
                input class="activities_id" type="hidden" value="${activities.id}">
                <h3>${activities.name}</h3>
            </div>    
            `;
          })
          .join("")}
        </ul>
    </div>
  `;
}