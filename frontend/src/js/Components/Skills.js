export default function Skills(skills) {
    return `
    <ul> 
    ${skills
      .map(skills => {
        return `
        <div class="skillDetails" id="skillDetail">        
            <h3>${skills.name}</h3>
            <input class="skill_id" type="hidden" value="${skills.id}">
        </div>    
        `;
      })
      .join("")}
  `;
}
