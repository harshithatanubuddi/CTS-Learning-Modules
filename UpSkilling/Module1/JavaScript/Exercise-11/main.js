// Form Element

const form =
    document.getElementById(
        "registrationForm"
    );

// Success Message

const successMessage =
    document.getElementById(
        "successMessage"
    );

// Form Submit Event

form.addEventListener(
    "submit",

    function(event){

        // Prevent Page Reload
        event.preventDefault();

        // Get Form Elements
        const username =
            form.elements["username"].value.trim();

        const email =
            form.elements["email"].value.trim();

        const selectedEvent =
            form.elements["event"].value;

        // Error Elements
        const nameError =
            document.getElementById(
                "nameError"
            );

        const emailError =
            document.getElementById(
                "emailError"
            );

        const eventError =
            document.getElementById(
                "eventError"
            );

        // Clear Previous Errors
        nameError.innerHTML = "";
        emailError.innerHTML = "";
        eventError.innerHTML = "";
        successMessage.innerHTML = "";

        let isValid = true;

        // Name Validation
        if(username === ""){

            nameError.innerHTML =
                "Name is required";

            isValid = false;
        }

        // Email Validation
        if(email === ""){

            emailError.innerHTML =
                "Email is required";

            isValid = false;
        }

        // Event Validation
        if(selectedEvent === ""){

            eventError.innerHTML =
                "Please select an event";

            isValid = false;
        }

        // Success Message
        if(isValid){

            successMessage.innerHTML =

                `
                Registration successful for
                ${selectedEvent}
                `;

            console.log({

                username,
                email,
                selectedEvent
            });

            // Reset Form
            form.reset();
        }
    }
);