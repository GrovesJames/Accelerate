import ActivityPlan from "./ActivityPlan"

export default function Skill(skill) {
    return `
    <div id="activitPlans">
        h2>Activities for this Skill</h2>
        ${skill.activityPlans.map(activityPlan => {
            ActivityPlan(activityPlan);
        })}
    </div>
    `
}