export default function EditActivity(activityEdit){
    return `
        <section class="main_content_activity">
            <h3>${activityEdit.description}</h3>
        </section>
    
        <section class="update_activity">        
        <input class="update_activity_ageRange" type="text" value="${activityEdit.ageRange}">
        <input class="update_activity_description" type="text" value="${activityEdit.description}">
        <input class="update_activity_duration" type="text" value="${activityEdit.duration}">
        <input class="update_activity_score" type="text" value="${activityEdit.score}">
        <button class="update_activity_submit">Save Changes</button>
        <input class="update_activity_id" type="hidden" value="${activityEdit.id}">
        <input class="update_activity_scheduleId" type="hidden" value="${activityEdit.scheduleId}>
        </section>
    `;
    
    }