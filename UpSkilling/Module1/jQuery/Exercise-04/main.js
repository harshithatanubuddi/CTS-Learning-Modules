$(document).ready(function(){

    $("#addBtn").click(function(){

        let value = $("#eventInput").val();

        if(value !== ""){

            let item = $("<li></li>")
                        .text(value);

            $("#eventList").append(item);

            $("#eventInput").val("");
        }

    });

    $("#removeBtn").click(function(){

        $("#eventList").empty();

    });

});