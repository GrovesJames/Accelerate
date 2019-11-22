export default function SingleactivityPlan(activityPlan){
    return `
    <div class = "singleActivity">
        <h2>${activityPlan.title}</h2>
        
        <h4>${activityPlan.ageRange}</h4>
        <p>${activityPlan.description}</p>
        <p>${activityPlan.duration}</p>
       


        <input type="date" id="start" name="trip-start"
       value="2018-09-22" min="2019-01-01" max="2021-12-31">

       <button class="add-toCalendar__submit">Add To Calendar</button>
    </div>
    `
}