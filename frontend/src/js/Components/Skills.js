export default function Skills(skills) {
    return `

    <div id="skillspage">
        <div id="skillsopener">
            <h2>Skills (3-5)</h2>
            <p>enter description of skills 3-5</p>
        </div>

        <div id="skill1grid">
            <div id="skill1name">
                <h3>API FILL NAME</h3>
            </div>
            <div id="skill1mile" class="skillbtns">
                <h6>Milestone</h6>
            </div>
            <div id="skill1act" class="skillbtns">
                <h6>Activities</h6>
            </div>
        </div>
        <div id="skill2grid">
            <div id="skill2name">
                <h3>API FILL NAME</h3>
            </div>
            <div id="skill2mile" class="skillbtns">
                <h6>Milestone</h6>
            </div>
            <div id="skill2act" class="skillbtns">
                <h6>Activities</h6>
            </div>
        </div>
        <div id="skill3grid">
            <div id="skill3name">
                <h3>API FILL NAME</h3>
            </div>
            <div id="skill3mile" class="skillbtns">
                <h6>Milestone</h6>
            </div>
            <div id="skill3act" class="skillbtns">
                <h6>Activities</h6>
            </div>
    </div>
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

