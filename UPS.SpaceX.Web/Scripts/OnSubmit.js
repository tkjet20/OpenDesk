// Below Function Executes On Form Submit
function ValidationEvent() {
    // Storing Field Values In Variables
    var desk = document.getElementById("OpenDeskList").value;
    var email = document.getElementById("emailField").value;

    // Regular Expression For Email
    var emailReg = /^([w-.]+@([w-]+.)+[w-]{2,4})?$/;

    // Conditions
    alert("works");
    if (desk != '' && email != '') {


        alert("All fields are required.....!");
        return false;

    } else {
        if (email.match(emailReg)) {
            if (desk.length == 5) {
                alert("All type of validation has done on OnSubmit event.");
                return true;
            } else {
                alert("The Contact No. must be at least 10 digit long!");
                return false;
            }
        } else {
            alert("Invalid Email Address...!!!");
            return false;
        }
    }
}


