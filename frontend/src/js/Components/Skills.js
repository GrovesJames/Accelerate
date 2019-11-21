export default function Skills(skills) {
    return `
    <ul> 
    ${skills
      .map(skills => {
        return `
        <div class="skillDetails" id="skillDetail">
            <input class="skill_id" type="hidden" value="${skills.id}">
        
            <article>
              <li>
                  <h3>${skills.name}</h3>
              </li>
            <input class="skill_id" type="hidden" value="${skills.id}">
            </article>
        </div>    
        `;
      })
      .join("")}
  `;
}
