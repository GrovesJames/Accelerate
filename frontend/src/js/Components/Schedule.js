import { Calendar } from '@fullcalendar/core';
import interactionPlugin, { Draggable } from '@fullcalendar/interaction';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGridPlugin from '@fullcalendar/timegrid';
import listPlugin from '@fullcalendar/list';
import '@fullcalendar/core/main.css';
import '@fullcalendar/daygrid/main.css';
import '@fullcalendar/timegrid/main.css';
import '@fullcalendar/list/main.css';
import '@fullcalendar/interaction';
import '@fullcalendar/resource-common';
import '@fullcalendar/timeline';
import '@fullcalendar/resource-daygrid';
import '@fullcalendar/resource-timegrid';
import '@fullcalendar/resource-timeline';
import '@fullcalendar/bootstrap';
import '@fullcalendar/google-calendar';

function calendar(){
    document.addEventListener('DOMContentLoaded', function() {
        let draggableEl = document.getElementById('mydraggable');
        var calendarEl = document.getElementById('calendar');
      
        let calendar = new Calendar(calendarEl, {
            plugins: [ dayGridPlugin, timeGridPlugin, listPlugin, interactionPlugin ],
            droppable: true
          });      
        calendar.render();
        new Draggable(draggableEl);
      });
}
function draggable(){
    document.addEventListener('DOMContentLoaded', function() {
    var Calendar = FullCalendar.Calendar;
    var Draggable = FullCalendarInteraction.Draggable;
    
    var containerEl = document.getElementById('external-events');
    var calendarEl = document.getElementById('calendar');
    var checkbox = document.getElementById('drop-remove');
    
    // initialize the external events
    // -----------------------------------------------------------------
    
    new Draggable(containerEl, {
        itemSelector: '.fc-event',
        eventData: function(eventEl) {
        return {
            title: eventEl.innerText
        };
        }
    });
    
    // initialize the calendar
    // -----------------------------------------------------------------
    
    var calendar = new Calendar(calendarEl, {
        plugins: [ 'interaction', 'dayGrid', 'timeGrid' ],
        header: {
        left: 'prev,next today',
        center: 'title',
        right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        editable: true,
        droppable: true, // this allows things to be dropped onto the calendar
        drop: function(info) {
        // is the "remove after drop" checkbox checked?
        if (checkbox.checked) {
            // if so, remove the element from the "Draggable Events" list
            info.draggedEl.parentNode.removeChild(info.draggedEl);
        }
        }
    });
    
    calendar.render();
    });
}

export default function Schedule() {
    calendar();
    draggable();
}