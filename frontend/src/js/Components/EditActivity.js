export default function EditActivity(activityEdit){
    return `
        <section class="main_content_activity">
            <h3>${activity.title}</h3>
        </section>
    
        <section class="update_activity">
        <input class="update_activity_title" type="text" value="${activity.title}">
        <input class="add_activity_ageRange" type="text" value="${activity.ageRange}">
        <input class="add_activity_description" type="text" value="${activity.description}">
        <input class="add_activity_duration" type="text" value="${activity.duration}">
        <input class="add_activity_score" type="text" value="${activity.score}">
        <button class="update_activity_submit">Save Changes</button>
        <input class="update_activity_id" type="hidden" value="${activity.id}">
        <input class="update_activity_scheduleId" type="hidden" value="${activity.scheduleId}>
        </section>
    `;
    
    }