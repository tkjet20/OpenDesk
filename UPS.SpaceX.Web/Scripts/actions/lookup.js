function selectEmail() {
    var email = document.getElementById("emailField").value;
    var Email = { email: email };
    return Email;
}

function showRecipientData() {
    $.ajax({
        type: "GET",
        url: "/Lookup/GetRecipientTable",
        data: selectEmail(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivReservedDesks").append($(response));
        }
    });
}

function showDonorData() {
    $.ajax({
        type: "GET",
        url: "/Lookup/GetDonorTable",
        data: selectEmail(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivDonatedDesks").append($(response));
        }
    });
}

function showKP() {
    $.ajax({
        type: "GET",
        url: "/Lookup/GetKP",
        data: selectEmail(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#KP").append($(response));
        }
    });
}