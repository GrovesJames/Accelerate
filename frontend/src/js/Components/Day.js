import DisplayActivity from "./ActivityDisplay"

export default function Day(activities) {

    let months = [
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"
        ];
    let activityDate = new Date(activities[0].activityTime);
    let daySelected = activityDate.getDate();
    let monthSelected = activityDate.getMonth()

    return `
    <div class="box">
        <div class="box2">
            <h1 id="dayname">Activities for: ${months[monthSelected]} ${daySelected}</h1>
            <div id="day-activity-list">
                <ul>
                ${activities.map( activity => {
                    return DisplayActivity(activity);
                    }).join("")
                }
                </ul>
            </div>
        </div>
    </div>
    `
}