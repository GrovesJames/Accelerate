export default function EditActivity(activityPlan){
    return `
        <section class="main_content_activity">
            <h3>${activityPlan.description}</h3>
        </section>
    
        <section class="update_activity">        
        <input class="update_activity_title" type="text" value="${activityPlan.title}">
        <input class="update_activity_ageRange" type="text" value="${activityPlan.ageRange}">
        <input class="update_activity_description" type="text" value="${activityPlan.description}">
        <input class="update_activity_duration" type="text" value="${activityPlan.duration}">
        <input class="update_activity_score" type="text" value="${activityPlan.score}">
        <button class="update_activity_submit">Save Changes</button>
        <input class="update_activity_id" type="hidden" value="${activityPlan.id}">
        <input class="update_activity_skillid" type="hidden" value="${activityPlan.skillsid}">
        </section>
    `;
    
    }