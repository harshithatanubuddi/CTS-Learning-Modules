// Events Array

const events = [

    {
        name: "Music Festival",
        date: "2026-06-15",
        seats: 10
    },

    {
        name: "Food Carnival",
        date: "2024-01-10",
        seats: 0
    },

    {
        name: "Sports Meet",
        date: "2026-07-01",
        seats: 5
    }

];

// Get Container

const container =
    document.getElementById("eventContainer");

// Current Date

const today =
    new Date();

// Display Events

events.forEach(event => {

    let eventDate =
        new Date(event.date);

    // Condition Check
    if(eventDate > today && event.seats > 0){

        // Create Card
        const card =
            document.createElement("div");

        card.classList.add("event-card");

        // Card Content
        card.innerHTML =

            `
            <h2>${event.name}</h2>

            <p>
                Event Date:
                ${event.date}
            </p>

            <p>
                Available Seats:
                <span id="${event.name}">
                    ${event.seats}
                </span>
            </p>

            <button onclick="register('${event.name}')">

                Register

            </button>
            `;

        // Append Card
        container.appendChild(card);
    }
});

// Registration Function

function register(eventName){

    try{

        // Find Event
        const selectedEvent =
            events.find(
                event => event.name === eventName
            );

        // Check Seats
        if(selectedEvent.seats <= 0){

            throw new Error(
                "No seats available!"
            );
        }

        // Reduce Seat Count
        selectedEvent.seats--;

        // Update UI
        document.getElementById(eventName).innerHTML =

            selectedEvent.seats;

        // Success Message
        alert(
            `Registration successful for ${eventName}`
        );
    }

    catch(error){

        console.error(error.message);

        alert(error.message);
    }
}