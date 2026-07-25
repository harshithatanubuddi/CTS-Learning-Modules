// Events Array using const

const events = [

    {
        name: "Music Festival",
        category: "Music",
        date: "June 15, 2026"
    },

    {
        name: "Food Carnival",
        category: "Food",
        date: "July 01, 2026"
    },

    {
        name: "Art Workshop",
        category: "Workshop",
        date: "August 10, 2026"
    }
];

// DOM Element

const container =
    document.getElementById(
        "eventContainer"
    );

// Function with Default Parameter

function createCard(event, heading = "Community Event"){

    // Destructuring
    const {
        name,
        category,
        date
    } = event;

    return `

    <div class="event-card">

        <h2>
            ${heading}
        </h2>

        <p>
            Event Name:
            ${name}
        </p>

        <p>
            Category:
            ${category}
        </p>

        <p>
            Event Date:
            ${date}
        </p>

    </div>
    `;
}

// Show Events

function showEvents(){

    container.innerHTML = "";

    events.forEach(event => {

        container.innerHTML +=

            createCard(event);
    });
}

// Spread Operator

function showClonedEvents(){

    // Clone Array
    let clonedEvents = [...events];

    console.log(clonedEvents);

    container.innerHTML = "";

    clonedEvents.forEach(event => {

        container.innerHTML +=

            createCard(
                event,
                "Cloned Event"
            );
    });
}

// Initial Display

showEvents();