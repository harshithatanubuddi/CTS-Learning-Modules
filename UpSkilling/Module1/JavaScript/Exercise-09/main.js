// Mock API URL

const apiURL =

    "https://jsonplaceholder.typicode.com/users";

// DOM Elements

const container =
    document.getElementById(
        "eventContainer"
    );

const loading =
    document.getElementById(
        "loading"
    );

// Display Events

function displayEvents(data){

    container.innerHTML = "";

    data.forEach(event => {

        const card =
            document.createElement("div");

        card.classList.add("event-card");

        card.innerHTML =

            `
            <h2>${event.name}</h2>

            <p>
                Email:
                ${event.email}
            </p>

            <p>
                City:
                ${event.address.city}
            </p>
            `;

        container.appendChild(card);
    });
}

// Fetch using Promises

function fetchWithPromises(){

    loading.style.display = "block";

    fetch(apiURL)

        .then(response => {

            return response.json();
        })

        .then(data => {

            loading.style.display = "none";

            displayEvents(data);

            console.log(data);
        })

        .catch(error => {

            loading.style.display = "none";

            console.error(error);

            alert(
                "Error fetching data"
            );
        });
}

// Fetch using Async/Await

async function fetchWithAsyncAwait(){

    try{

        loading.style.display = "block";

        const response =
            await fetch(apiURL);

        const data =
            await response.json();

        loading.style.display = "none";

        displayEvents(data);

        console.log(data);
    }

    catch(error){

        loading.style.display = "none";

        console.error(error);

        alert(
            "Error fetching data"
        );
    }
}