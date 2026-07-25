// Register Button Click

$("#registerBtn").click(function(){

    alert(
        "Registration Successful"
    );

    console.log(
        "Register button clicked"
    );
});

// Fade Out Event Card

$("#hideBtn").click(function(){

    $("#eventCard").fadeOut();
});

// Fade In Event Card

$("#showBtn").click(function(){

    $("#eventCard").fadeIn();
});

// Console Message

console.log(
    "jQuery Loaded Successfully"
);