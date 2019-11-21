export default function Activities() {
    return `
        <div id="calwrap">
            <div id="year"></div>
            <div id="month"></div>
            <div id="monthAndYear"></div>
            <div>
                <button id="calendar-prev">Previous</button>
                <button id="calendar-next">Next</button>
            </div>
            <div id="calendar-body">Body</div>
            <div id="calendar-day"></div>
        </div>
        <button id="calendar-daySchedule">Day</button>
    `
}