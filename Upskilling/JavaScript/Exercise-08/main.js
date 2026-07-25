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

// DOM Elements

const container =
    document.getElementById(
        "eventContainer"
    );

const searchInput =
    document.getElementById(
        "searchInput"
    );

const categoryFilter =
    document.getElementById(
        "categoryFilter"
    );

// Display Events

function displayEvents(eventList){

    container.innerHTML = "";

    eventList.forEach((event, index) => {

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

            <button onclick="register(${index})">

                Register

            </button>
            `;

        container.appendChild(card);
    });
}

// Register Button Event

function register(index){

    if(events[index].seats > 0){

        events[index].seats--;

        alert(
            `Registered for ${events[index].name}`
        );

        applyFilters();
    }

    else{

        alert(
            "No seats available"
        );
    }
}

// Filter Events

function applyFilters(){

    const searchText =
        searchInput.value.toLowerCase();

    const selectedCategory =
        categoryFilter.value;

    let filteredEvents =
        events.filter(event => {

            const matchesSearch =

                event.name
                .toLowerCase()
                .includes(searchText);

            const matchesCategory =

                selectedCategory === "All"
                ||
                event.category === selectedCategory;

            return matchesSearch
                   &&
                   matchesCategory;
        });

    displayEvents(filteredEvents);
}

// onchange Event

categoryFilter.onchange =
    applyFilters;

// keydown Event

searchInput.onkeydown =
    function(){

        setTimeout(applyFilters, 100);
    };

// Initial Display

displayEvents(events);

// Console Output

console.log(events);