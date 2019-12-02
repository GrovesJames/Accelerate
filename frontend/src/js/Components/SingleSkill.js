export default function SingleSkill(skill) {
  return `
    <div id="skilldetail">
      <article id="skillsheader">
        <ul id="skill-detail-list">
          <li>
          <div id="skilldesc">
            <h3><strong>${skill.name}</strong></h3>
              <h4>${skill.description}</h4>
            </div>
            <div id="skillpic">
              <img src="${skill.image}"></img>
            </div>
            <input id="skill_id" class="skill_id" type="hidden" value="${
              skill.id
            }">
          </li>
        </ul>
      </article>
      <div class="box">
        <div class="box2">
          <h5><strong>Milestones</strong></h5>
          <ul> 
          ${skill.milestones
            .map(milestones => {
              let checkElement = null;
              if (milestones.completed == true) {
                checkElement = `<label class="toggle">
                <input class="milestone_check" type="checkbox" id="completed" checked>
                <span class="toggle__label">
                  <span class="toggle__text"></span>
                </span>
                </label>`;
              } else {
                checkElement = `<label class="toggle">
                <input class="milestone_check" type="checkbox" id="completed">
                <span class="toggle__label">
                <span class="toggle__text"></span>
              </span>
              </label>`;
              }

              return `
              <li class="miles">
              ${milestones.milestone}
              <form>
                ${checkElement}
                <input class="milestones_checked" type="hidden" value="${milestones.completed}">
                <input class="milestones_milestone" type="hidden" value="${milestones.milestone}"/>
                <input class="milestones_AgeRange" type="hidden" value="${milestones.ageRange}"/>
                <input class="milestones_id" type="hidden" value="${milestones.id}"/>
                <input id="skill_id" class="skill_id" type="hidden" value="${skill.id}"/>
              </form>
              </li>
            `;
            })
            .join('')}
          </ul>
        </div>
      </div>
  `;
}
