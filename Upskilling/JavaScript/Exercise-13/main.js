// Form Element

const form =
    document.getElementById(
        "registrationForm"
    );

// Status Message

const statusMessage =
    document.getElementById(
        "statusMessage"
    );

// Submit Event

form.addEventListener(

    "submit",

    function(event){

        // Prevent Reload
        event.preventDefault();

        // Debug Logs
        console.log(
            "Form submission started"
        );

        // Get Values
        const username =
            document.getElementById(
                "username"
            ).value;

        const email =
            document.getElementById(
                "email"
            ).value;

        // Inspect Variables
        console.log(
            "Username:",
            username
        );

        console.log(
            "Email:",
            email
        );

        // Payload Object
        const payload = {

            username,
            email
        };

        // Check Payload
        console.log(
            "Payload:",
            payload
        );

        // Debugger Breakpoint
        debugger;

        // Fetch Request
        fetch(

            "https://jsonplaceholder.typicode.com/posts",

            {

                method: "POST",

                headers: {

                    "Content-Type":
                    "application/json"
                },

                body:
                JSON.stringify(payload)
            }
        )

        .then(response => {

            console.log(
                "Response received"
            );

            return response.json();
        })

        .then(data => {

            console.log(
                "Success Data:",
                data
            );

            statusMessage.style.color =
                "green";

            statusMessage.innerHTML =

                `
                Registration Successful
                `;

            // Reset Form
            form.reset();
        })

        .catch(error => {

            console.error(
                "Fetch Error:",
                error
            );

            statusMessage.style.color =
                "red";

            statusMessage.innerHTML =

                `
                Registration Failed
                `;
        });
    }
);