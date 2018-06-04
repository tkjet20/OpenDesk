$(document).ready(function () {
    GetAvailableDesks();
});

function GetAvailableDesks() {
    $.ajax({
        type: "GET",
        url: "/SpaceX/GetAvailableDesks",
        error: function (xhr, status, error) {

        },
    success: function (response) {
        $("#DivAvailableDesks").append($(response));
    }
    });
}