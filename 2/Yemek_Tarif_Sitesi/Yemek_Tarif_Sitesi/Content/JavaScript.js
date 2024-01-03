$(document).ready(function () {
    $("form").submit(function (event) {
        event.preventDefault();

        var name = $("#Name").val();
        var message = $("#Message").val();

        var newComment = "<div><strong>" + name + "</strong><p>" + message + "</p></div>";

        $("#comments").append(newComment);

        $("#Name, #Message").val("");
    });
});