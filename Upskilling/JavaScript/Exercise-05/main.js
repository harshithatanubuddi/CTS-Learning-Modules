// Event Constructor Function

function Event(name, category, seats){

    this.name = name;

    this.category = category;

    this.seats = seats;
}

// Prototype Method

Event.prototype.checkAvailability = function(){

    if(this.seats > 0){

        return "Seats Available";
    }

    else{

        return "No Seats Available";
    }
};

// Create Event Objects

const event1 =
    new Event(
        "Music Festival",
        "Music",
        20
    );

const event2 =
    new Event(
        "Food Carnival",
        "Food",
        0
    );

// Events Array

const events = [

    event1,
    event2
];

// Get Container

const container =
    document.getElementById(
        "eventContainer"
    );

// Display Events

events.forEach(event => {

    // Create Card
    const card =
        document.createElement("div");

    card.classList.add("event-card");

    // Object Entries
    let details = "";

    Object.entries(event).forEach(([key, value]) => {

        details +=

            `<p>
                <strong>${key}</strong> :
                ${value}
            </p>`;
    });

    // Availability
    const availability =
        event.checkAvailability();

    // Card Content
    card.innerHTML =

        `
        <h2>${event.name}</h2>

        ${details}

        <p class="${
            availability === "Seats Available"
            ?
            "available"
            :
            "not-available"
        }">

            ${availability}

        </p>
        `;

    // Append Card
    container.appendChild(card);
});

// Console Output

console.log(event1);

console.log(event2);