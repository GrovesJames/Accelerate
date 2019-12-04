
export default function Skills(skills) {
    function GetProgress(skill){
        let numMilestonesComplete = 0;
        let numMilestonesTotal = skill.milestones.length;
        for (var i = 0; i < skill.milestones.length; i++) {
            let skillMilestone = skill.milestones[i];
            if(skillMilestone.completed == true) numMilestonesComplete++;
        }
        let PercentProgress = (numMilestonesComplete/numMilestonesTotal)*100;
        return PercentProgress;
    }
    function ProgressBar(skill){
        let percentProgress = GetProgress(skill);
        return `
            <div class="progress-bar${skill.id}" style="width:${percentProgress}%"></div>
        `
    }

    return `
    <div id="skillspage">
        <div id="skillsopener">
            <h2>Skills (Ages 3-5)</h2>
            <p>Each 'skill' is broken down by its particular set of milestones, from which parents or caregivers can be educated on what areas of improvement are necessary for their child. Activities are then suggested that assist in the development and improvement of these skills. Afterwards, you may create a personalized profile for your child, where you can develop a schedule based on activities chosen.</p>
        </div>

        <div id="skillsNgraph">
            <div id="gridwrap">
                <h3>Speech</h3>
                <div id="skill1grid">
                    <div id="skill1name">
                        <button class="button-skill" value="1"></button>
                        <h3>Milestones</h3>
                    </div>
                    <div id="skill1act" class="skill1btns">
                        <button class="button-activities" value="1"></button>
                        <h6>Activities</h6>
                    </div>
                </div>
                <h3>Cognitive Functionality</h3>
                <div id="skill2grid">
                    <div id="skill2name">
                        <button class="button-skill" value="2"></button>
                        <h3>Milestones</h3>
                    </div>
                    <div id="skill2act" class="skill2btns">
                        <button class="button-activities" value="2"></button>
                        <h6>Activities</h6>
                    </div>
                </div>
                <h3>Fine/Gross Motor Skills</h3>
                <div id="skill3grid">
                    <div id="skill3name">
                        <button class="button-skill" value="3"></button>
                        <h3>Milestones</h3>
                    </div>
                    <div id="skill3act" class="skill3btns">
                        <button class="button-activities" value="3"></button>
                        <h6>Activities</h6>
                    </div>
                </div>
            </div>
        <div id="graph">
            <div id="graph1">
                <h6 class="graphskill" id="graphskill1">Speech</h6>
                ${ProgressBar(skills[0])}
            </div>
            <div id="graph2">
                <h6 class="graphskill" id="graphskill2">Cognitive Functionality</h6>
                ${ProgressBar(skills[1])}
            </div>
            <div id="graph3">
                <h6 class="graphskill" id="graphskill3">Motor Skills</h6>
                ${ProgressBar(skills[2])}
            </div>
        </div>
    </div>
`}