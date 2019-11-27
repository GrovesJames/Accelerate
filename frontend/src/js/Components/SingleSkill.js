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
            return `
              <li>
                <input type="checkbox" id="completed">
                ${milestones.milestone}
                <input class="milestones_id" type="hidden" value="${milestones.id}">
                <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}">
              </li>
            `;
        }).join("")}
          </ul>
        </div>
      </div>
  `;
}

