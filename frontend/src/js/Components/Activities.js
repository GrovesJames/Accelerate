export default function Activities(activities){
    return `
    <section id="activitieswrapper'>
    ${activities
    .map(activity => {
        return `
        <ul>
            <li class="activitiesgrid" >
            <h3>${activity.title}</h3>
            <h4>Age Range: ${activity.ageRange}</h4>
            <h4>Description: ${activity.description}</h4>
            <h4>Duration: ${activity.duration}</h4>
            <h4>Score: ${activity.score}</h4>
            <input class="activity_id" type="hidden" value="${activity.id}">
            <button class="edit_activity_submit">Edit</button>
            <button class="delete_activity_submit">Delete</button>
            </li>
            </ul>
        `;    
    })
    .join("")}
    </section>
    

    <section class="add_activity">
        <h3>Add A New Activity!</h3>        
        <input class="add_activity_title" type="text" placeholder="Title">
        <input class="add_activity_ageRange" type="text" placeholder="Age Range">
        <input class="add_activity_description" type="text" placeholder="Description">
        <input class="add_activity_duration" type="text" placeholder="Duration">
        <input class="add_activity_score" type="text" placeholder="Score">        
        <button class="add_activity_submit">Submit</button>
    </section>        
    
    `;
}