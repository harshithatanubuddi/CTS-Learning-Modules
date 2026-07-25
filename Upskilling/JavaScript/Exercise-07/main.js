// Events Array

const events = [

    {
        name: "Music Festival",
        category: "Music",
        seats: 20
    },

    {
        name: "Food Carnival",
        category: "Food",
        seats: 15
    },

    {
        name: "Art Workshop",
        category: "Workshop",
        seats: 10
    }

];

// Select Container using querySelector()

const container =
    document.querySelector(
        ".event-container"
    );

// Render Events Function

function renderEvents(){

    // Clear Previous UI
    container.innerHTML = "";

    // Loop Through Events
    events.forEach((event, index) => {

        // Create Card
        const card =
            document.createElement("div");

        // Add Class
        card.classList.add("event-card");

        // Card Content
        card.innerHTML =

            `
            <h2>${event.name}</h2>

            <p>
                Category:
                ${event.category}
            </p>

            <p>
                Available Seats:
                <span id="seat-${index}">
                    ${event.seats}
                </span>
            </p>

            <button
                class="register-btn"
                onclick="register(${index})">

                Register

            </button>

            <button
                class="cancel-btn"
                onclick="cancel(${index})">

                Cancel

            </button>
            `;

        // Append Card
        container.appendChild(card);
    });
}

// Register Function

function register(index){

    if(events[index].seats > 0){

        events[index].seats--;

        renderEvents();

        alert(
            `Registered for ${events[index].name}`
        );
    }

    else{

        alert(
            "No seats available"
        );
    }
}

// Cancel Function

function cancel(index){

    events[index].seats++;

    renderEvents();

    alert(
        `Registration cancelled for ${events[index].name}`
    );
}

// Initial Render

renderEvents();

// Console Output

console.log(events);