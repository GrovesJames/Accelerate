import CalendarActivity from "./CalendarActivity";
import Day from './Day';

export default function Schedule(schedule) {
    
    let nextButton = document.getElementById("calendar-next");
    let prevButton = document.getElementById("calendar-prev");
    let daySchedule = document.getElementById("calendar-daySchedule");

    let today = new Date();
    let currentMonth = today.getMonth();
    let currentYear = today.getFullYear();
    let selectYear = document.getElementById("year");
    let selectMonth = document.getElementById("month");
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
        
    const navDay = document.getElementById('calendar-day');
    function dayNAV() {
        navDay.addEventListener('click', function() {
            app.innerHTML = "Day();";
        });
    }

    nextButton.addEventListener("click", function(){
        next();
    });

    prevButton.addEventListener("click", function(){
        previous();
    });

    function showSchedule(schedule){
        schedule.activities.map( activity => {
            let activityMonth = activity.month;
            let activityDay = activity.day;
            if(activityMonth == currentMonth){
                let dayCell = document.getElementById(activityDay);
                let calendarActivity = document.createElement("div");
                calendarActivity.innerHTML = CalendarActivity(activity);
                dayCell.appendChild(calendarActivity);
            }
        })
    }

    let monthAndYear = document.getElementById("monthAndYear");
    showCalendar(currentMonth, currentYear);

    function next() {
    currentYear = currentMonth === 11 ? currentYear + 1 : currentYear;
    currentMonth = (currentMonth + 1) % 12;
    showCalendar(currentMonth, currentYear);
    }
    function previous() {
    currentYear = currentMonth === 0 ? currentYear - 1 : currentYear;
    currentMonth = currentMonth === 0 ? 11 : currentMonth - 1;
    showCalendar(currentMonth, currentYear);
    }
    function jump() {
    currentYear = parseInt(selectYear.value);
    currentMonth = parseInt(selectMonth.value);
    showCalendar(currentMonth, currentYear);
    }
    function showCalendar(month, year) {
    let firstDay = new Date(year, month).getDay();
    var tbl = document.getElementById("calendar-body"); // body of the calendar
    // clearing all previous cells
    tbl.innerHTML = "";
    // filing data about month and in the page via DOM.
    monthAndYear.innerHTML = months[month] + " " + year;
    selectYear.value = year;
    selectMonth.value = month;
    // creating all cells
    let date = 1;
    for (let i = 0; i < 6; i++) {
        // creates a table row
        let row = document.createElement("tr");
        //creating individual cells, filing them up with data.
        for (let j = 0; j < 7; j++) {
        if (i === 0 && j < firstDay) {
            var cell = document.createElement("td");
            var cellText = document.createTextNode("");
            cell.appendChild(cellText);
            row.appendChild(cell);
        } else if (date > daysInMonth(month, year)) {
            break;
        } else {
            var cell = document.createElement("td");
            var cellText = document.createTextNode(date);
            if (
            date === today.getDate() &&
            year === today.getFullYear() &&
            month === today.getMonth()
            ) {
            cell.classList.add("bg-info");
            } // color today's date
            cell.className = "indday";
            cell.id = date;
            cell.appendChild(cellText);
            row.appendChild(cell);
            date++;
        }
        }
        tbl.appendChild(row); // appending each row into calendar body.
    }
    showSchedule(schedule);
    addDayButtons();
    }
    // check how many days in a month code from https://dzone.com/articles/determining-number-days-month
    function daysInMonth(iMonth, iYear) {
    return 32 - new Date(iYear, iMonth, 32).getDate();
    }

    function addDayButtons(){
        const dayCells = document.getElementsByClassName("indday");
        for (var i = 0; i < dayCells.length; i++) {
            dayCells[i].addEventListener('click', function(){
                let dayCell = event.target;
                let dayNum = dayCell.id
                let dayActivities = [];
                schedule.activities.map( activity => {
                    let activityDay = activity.day;
                    if(dayNum == activityDay) dayActivities.push(activity);
                })
                daySchedule.innerHTML = Day(dayActivities);
            });
        }
    }

}