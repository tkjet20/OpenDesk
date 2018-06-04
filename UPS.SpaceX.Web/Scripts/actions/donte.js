function getMydata() {
    var email = document.getElementById("emailField").value;
    var desk = document.getElementById("OpenDeskList").value;
    var date = document.getElementById("date").value;
    var karmaPoints = 0;
    var isAvailable = true;
    var donor = { Email: email, Desk: desk, Date: date, karmaPoints: karmaPoints, isAvailable: isAvailable };
    return donor;
}

function addDonor() {
     $.ajax({
        type: "POST",
         url: "/Donate/Create",
         data: getMydata(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivAvailableDesks").append($(response));
        }
    });
}

function updateKP() {
    $.ajax({
        type: "POST",
        url: "/Donate/UpdateKP",
        data: getMydata(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivAvailableDesks").append($(response));
        }
    });
}