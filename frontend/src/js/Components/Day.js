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
    let daySelected = activities[0].day;
    let monthSelected = months[activities[0].month];

    return `
    <h1>Activities for ${monthSelected} ${daySelected}</h1>
    <div id="day-activity-list">
        ${activities.map( activity => {
            return DisplayActivity(activity);
            })
        }
    </div>
    `
}