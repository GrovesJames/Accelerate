export default function EditActivity(activityplan){
    return `
        <section class="main_content_activity">
            <h3>${activityplan.description}</h3>
        </section>
    
        <section class="update_activity">        
        <input class="update_activity_title" type="text" value="${activityplan.title}">
        <input class="update_activity_ageRange" type="text" value="${activityplan.ageRange}">
        <input class="update_activity_description" type="text" value="${activityplan.description}">
        <input class="update_activity_duration" type="text" value="${activityplan.duration}">
        <input class="update_activity_score" type="text" value="${activityplan.score}">
        <button class="update_activity_submit">Save Changes</button>
        <input class="update_activity_id" type="hidden" value="${activityplan.id}">
        <input class="update_activity_skillid" type="hidden" type="int" value="${activityplan.skillsId}">
        </section>
    `;
    
    }