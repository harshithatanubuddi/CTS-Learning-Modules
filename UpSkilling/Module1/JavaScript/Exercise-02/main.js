// Event Details

const eventName =
    "Music Festival";

const eventDate =
    "June 15, 2026";

let availableSeats =
    50;

// Display Event Information

document.getElementById("eventName").innerHTML =

    `${eventName}`;

document.getElementById("eventDate").innerHTML =

    `Event Date: ${eventDate}`;

document.getElementById("seatCount").innerHTML =

    `Available Seats: ${availableSeats}`;

// Registration Function

function registerUser(){

    // Decrease seat count
    availableSeats--;

    // Update UI
    document.getElementById("seatCount").innerHTML =

        `Available Seats: ${availableSeats}`;

    // Console Output
    console.log(

        `${eventName} registration successful. Remaining seats: ${availableSeats}`
    );

    // Alert Message
    alert(

        `Registration successful for ${eventName}`
    );
}