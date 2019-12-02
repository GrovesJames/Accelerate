export default function DisplayActivity(activity) {
    return `
        <li>
        <h2>${activity.title}</h2>
        <p>${activity.activityTime}</p>
        <button class="activity-delete-btn" value=${activity.id}>Delete</button>
        </li>
    `
}