export default function ActivityPlan(activityPlan) {
    return `
    <h2>${activityPlan.title}</h2>
    <span>${activityPlan.description}</span>
    <span>${activityPlan.duration}</span>
    <form>
        <input class="activity-plan_id" type="hidden" value=${activityPlan.id}
        <input class="activity-plan_title" type="hidden" value=${activityPlan.title}
        <input class="activity-plan_description" type="hidden" value=${activityPlan.description}
        <input class="activity-plan_score" type="hidden" value=${activityPlan.score}
        <input class="activity-plan_duration" type="hidden" value=${activityPlan.duration}
        <input class=&quot;add-activity_plan&quot; type=&quot;datetime-local&quot; />  
        <input class="activity-plan_submit" type="submit" value="Submit"> 
    </form>
    
    `
}