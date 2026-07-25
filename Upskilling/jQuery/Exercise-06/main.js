$(document).ready(function(){

    // Click Event

    $("#eventBox").click(function(){

        $(this)
        .css("background-color", "#198754")
        .text("Clicked!");
    });

    // Double Click Event

    $("#eventBox").dblclick(function(){

        $(this)
        .css("background-color", "#dc3545")
        .text("Double Clicked!");
    });

    // Mouse Enter Event

    $("#eventBox").mouseenter(function(){

        $(this)
        .css("background-color", "#0d6efd")
        .text("Mouse Entered!");
    });

    // Mouse Leave Event

    $("#eventBox").mouseleave(function(){

        $(this)
        .css("background-color", "#e9ecef")
        .text("Mouse Left!");
    });

    // Keypress Event

    $("#inputBox").keypress(function(){

        $("#output").text(

            "Typed: " +

            $(this).val()

        );

    });

});