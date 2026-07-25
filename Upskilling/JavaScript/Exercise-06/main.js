// Events Array

const events = [];

// Add Events using push()

events.push({

    name: "Music Festival",

    category: "Music",

    date: "June 15, 2026"
});

events.push({

    name: "Workshop on Baking",

    category: "Workshop",

    date: "July 02, 2026"
});

events.push({

    name: "Dance Night",

    category: "Music",

    date: "August 10, 2026"
});

events.push({

    name: "Food Carnival",

    category: "Food",

    date: "September 01, 2026"
});

// Get Container

const container =
    document.getElementById(
        "eventContainer"
    );

// Display Function using map()

function displayEvents(eventList){

    container.innerHTML = "";

    // Map Method
    const cards =
        eventList.map(event => {

            return `

            <div class="event-card">

                <h2>
                    ${event.name}
                </h2>

                <p>
                    Category:
                    ${event.category}
                </p>

                <p>
                    Event Date:
                    ${event.date}
                </p>

            </div>
            `;
        });

    // Render Cards
    container.innerHTML =
        cards.join("");
}

// Show All Events

function showAllEvents(){

    displayEvents(events);
}

// Filter Music Events

function showMusicEvents(){

    const musicEvents =

        events.filter(event =>

            event.category === "Music"
        );

    displayEvents(musicEvents);
}

// Initial Display

showAllEvents();

// Console Output

console.log(events);