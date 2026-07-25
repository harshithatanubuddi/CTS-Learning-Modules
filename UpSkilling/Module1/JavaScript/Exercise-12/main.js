// Form Element

const form =
    document.getElementById(
        "registrationForm"
    );

// Loading Element

const loading =
    document.getElementById(
        "loading"
    );

// Response Element

const responseMessage =
    document.getElementById(
        "responseMessage"
    );

// Submit Event

form.addEventListener(

    "submit",

    function(event){

        // Prevent Reload
        event.preventDefault();

        // User Data
        const userData = {

            username:
                document.getElementById(
                    "username"
                ).value,

            email:
                document.getElementById(
                    "email"
                ).value
        };

        // Show Loading
        loading.style.display = "block";

        responseMessage.innerHTML = "";

        // Simulate Delay
        setTimeout(() => {

            // Fetch POST Request
            fetch(

                "https://jsonplaceholder.typicode.com/posts",

                {

                    method: "POST",

                    headers: {

                        "Content-Type":
                        "application/json"
                    },

                    body:
                    JSON.stringify(userData)
                }
            )

            .then(response => {

                return response.json();
            })

            .then(data => {

                // Hide Loading
                loading.style.display = "none";

                // Success Message
                responseMessage.style.color =
                    "green";

                responseMessage.innerHTML =

                    `
                    Registration Successful
                    `;

                console.log(data);

                // Reset Form
                form.reset();
            })

            .catch(error => {

                // Hide Loading
                loading.style.display = "none";

                // Failure Message
                responseMessage.style.color =
                    "red";

                responseMessage.innerHTML =

                    `
                    Registration Failed
                    `;

                console.error(error);
            });

        }, 2000);
    }
);