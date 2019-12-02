export default function ActivityPlan(activityPlan) {
    return `

     
            <section class="activity-plan_form">
            <h2>${activityPlan.title}</h2>
            <p>Description: ${activityPlan.description}</p>
            <p>Duration: ${activityPlan.duration}</p>
            <form>
                <input class="activity-plan_title" type="hidden" value="${activityPlan.title}">
                <input class="activity-plan_description" type="hidden" value=${activityPlan.description}>
                <input class="activity-plan_score" type="hidden" value=${activityPlan.score}>
                <input class="activity-plan_duration" type="hidden" value=${activityPlan.duration}>
                <input class="activity-plan-id" type="hidden" value=${activityPlan.id}>
                <input class="add-activity_plan" type="datetime-local"> 
                <button class="activity-plan_submit" type="button">Add to Calendar</button> 
                <button class="activity-plan-edit" type="button">Edit</button>
                <button class="activity-delete-btn" type="button">Delete</button>
            </form>
            </section>          
                      
            
            `;        
  

    

}