export default function EditActivity(activityplan){
    return `
        <div id="editwrap">
            <section class="main_content_activity">
                <h3>Edit ${activityplan.description}</h3>
            </section>
        
            <section class="update_activity">
            <div class="inputs">        
                <input class="update_activity_title" type="text" value="${activityplan.title}">
                <input class="update_activity_ageRange" type="text" value="${activityplan.ageRange}">
                <input class="update_activity_description" type="text" value="${activityplan.description}">
                <input class="update_activity_duration" type="text" value="${activityplan.duration}">
                <input class="update_activity_score" type="text" value="${activityplan.score}">
                <input class="update_activity_id" type="hidden" value="${activityplan.id}">
                <input class="update_activity_skillid" type="hidden" type="int" value="${activityplan.skillsId}">
                <button class="update_activity_submit">Save Changes</button>
            </div>
            </section>
        </div>
    `;
    
    }