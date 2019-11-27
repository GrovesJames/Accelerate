export default function DisplayActivity(activity) {
    return `
        <h2>${activity.title}</h2>
        <p>${activity.description}</p>
        <button class="activity-delete-btn" value=${activity.id}>Delete</button>
    `
}