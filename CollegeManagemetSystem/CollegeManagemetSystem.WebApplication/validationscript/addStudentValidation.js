

function validateFirstName() {
    var x = document.forms["AddStudent"]["FirstName"].value;
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
}
function validateLastName() {
    var x = document.forms["AddStudent"]["LastName"].value;
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
}
function ValidateEmail() {
    var email = document.getElementById("txtEmail").value;
    var lblError = document.getElementById("lblError");
    lblError.innerHTML = "";
    var expr = /^([\w-\.]+)@@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    if (!expr.test(email)) {
        lblError.innerHTML = "Invalid email address.";
    }
}