export default function DisplayActivity(activity) {
    let activityDateObject = new Date(activity.activityTime)
    let time = activityDateObject.toLocaleString("en-US", {timeZone: "America/New_York"})
    return `
        <li>
            <h2>${activity.title}</h2>
            <p>${time}</p>
            <button class="activityday-delete-btn" value=${activity.id}>Delete</button>
        </li>
    `
}