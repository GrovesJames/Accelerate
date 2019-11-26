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
    <h1>Activities for ${months[monthSelected]} ${daySelected}</h1>
    <div id="day-activity-list">
        ${activities.map( activity => {
            return DisplayActivity(activity);
            })
        }
    </div>
    `
}