// Events Array

const events = [];

// Add Event Function

function addEvent(name, category, seats){

    events.push({

        name,
        category,
        seats
    });
}

// Add Sample Events

addEvent(
    "Music Festival",
    "Music",
    20
);

addEvent(
    "Food Carnival",
    "Food",
    15
);

addEvent(
    "Dance Show",
    "Music",
    10
);

// Closure Function

function registrationTracker(){

    let totalRegistrations = 0;

    return function(){

        totalRegistrations++;

        document.getElementById(
            "registrationCount"
        ).innerHTML =

            `Total Registrations: ${totalRegistrations}`;
    };
}

// Create Closure Instance

const trackRegistration =
    registrationTracker();

// Register User Function

function registerUser(eventName){

    const event =
        events.find(
            event => event.name === eventName
        );

    if(event.seats > 0){

        event.seats--;

        trackRegistration();

        alert(
            `Registered for ${eventName}`
        );

        showAllEvents();
    }

    else{

        alert(
            "No seats available"
        );
    }
}

// Higher Order Function

function filterEventsByCategory(callback){

    return events.filter(callback);
}

// Display Events

function displayEvents(eventList){

    const container =
        document.getElementById(
            "eventContainer"
        );

    container.innerHTML = "";

    eventList.forEach(event => {

        const card =
            document.createElement("div");

        card.classList.add("event-card");

        card.innerHTML =

            `
            <h2>${event.name}</h2>

            <p>
                Category:
                ${event.category}
            </p>

            <p>
                Available Seats:
                ${event.seats}
            </p>

            <button onclick="registerUser('${event.name}')">

                Register

            </button>
            `;

        container.appendChild(card);
    });
}

// Show All Events

function showAllEvents(){

    displayEvents(events);
}

// Filter Music Events

function showMusicEvents(){

    const musicEvents =
        filterEventsByCategory(

            event => event.category === "Music"
        );

    displayEvents(musicEvents);
}

// Initial Display

showAllEvents();