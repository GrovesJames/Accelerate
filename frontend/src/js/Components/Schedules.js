export default function Schedules (schedule) {
    return `
    ${schedule
        .map(schedule => {
            return `
            <section class="schedulegrid">
            <input class="schedule_id" type="hidden" value="${schedule.id}">
            </section>            
            `;
        })    
    .join("")}
    `;
}