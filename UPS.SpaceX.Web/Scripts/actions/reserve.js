function selectDate()
{
    var date = document.getElementById("date").value;
    var Date = { date: date };
    return Date;
}

function showData() {
    $.ajax({
        type: "GET",
        url: "/Reserve/GetGivers",
        data: selectDate(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivAvailableDesks").append($(response)).fadeIn("slow");
        }
    });
}


//function selectfromOriginal() {
//    var date = document.getElementById("date").value;
//    var email = document.getElementById("emailField").value;
//    var obj = { date: date, email: email };
//    return obj;

//    // date, email
//}

//function selectfromPartial() {
//    var desk = document.getElementById("deskVal").value;
//    var desk = { desk: desk };
//    return desk;

//    //desk
//}

function DataTogether() {
    var date = document.getElementById("date").value;
    var email = document.getElementById("emailField").value;
    var desk = document.getElementById("DropDownAvailableDesks").value;
    var obj = { desk: desk, date: date, email: email };
    return obj;
}

function Reserve() {
    $.ajax({
        type: "POST",
        url: "/Reserve/InsertRecord",
        data: DataTogether(),
        error: function (xhr, status, error) {

        },
        success: function (response) {

        }
    });
}

function getDeskDate() {
    var desk = document.getElementById("DropDownAvailableDesks").value;
    var date = document.getElementById("date").value;
    var obj = { desk: desk, date: date };
    return obj;
}

function updateFlag() {
    $.ajax({
        type: "POST",
        url: "/Reserve/UpdateDonorFlag",
        data: getDeskDate(),
        error: function (xhr, status, error) {

        },
        success: function (response) {
            $("#DivAvailableDesks").append($(response));
        }
    });
}


