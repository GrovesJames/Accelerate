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
      <div class="box">
        <div class="box2">
          <h5>Milestones</h5>
          <ul> 
          ${skill.milestones.map(milestones => {
            let checkElement = null;
            if(milestones.completed == true){checkElement = `<input class="milestone_check" type="checkbox" id="completed" checked>`}
            else{ checkElement = `<input class="milestone_check" type="checkbox" id="completed">`}

            return `
              <li>
              ${milestones.milestone}
              <form>
                ${checkElement}
                <input class="milestones_milestone" type="hidden" value="${milestones.milestone}">
                <input class="milestones_AgeRange" type="hidden" value="${milestones.ageRange}">
                <input class="milestones_id" type="hidden" value="${milestones.id}">
                <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
              </form>
              </li>
            `;
        }).join("")}
          </ul>
        </div>
      </div>
  `;
}

