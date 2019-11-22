export default function ActivityPlan(activityPlan) {
    return `
    <h2>${activityPlan.title}</h2>
    <span>${activityPlan.description}</span>
    <span>${activityPlan.duration}</span>
    <button>Add to Calendar</button>
    `
}