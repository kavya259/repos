//<script type="text/javascript">
    //function validation() {
    //        var name = document.getElementById('name').value;
    //        var mobile = document.getElementById('mobile').value;
    //        var email = document.getElementById('email').value;
    //        if (name == "") {
    //    document.getElementById('nameerror').innerHTML = "* please fill in the name";
    //            return false;
    //        }
    //        if ((name.length < 3) || (name.length>20)) {
    //    document.getElementById('nameerror').innerHTML = "* name must be between 3 to 20 characters";
    //            return false;
    //        }
    //        if (!isNaN(name)) {
    //    document.getElementById('nameerror').innerHTML = "* Only characters are allowed";
    //            return false;
    //        }
    //        if (mobile == "") {
    //    document.getElementById('mobileerror').innerHTML = "* please fill in the mobile number";
    //            return false;
    //        }
    //        if (mobile.length != 10) {
    //    document.getElementById('mobileerror').innerHTML = "*  mobile number must have 10 digits ";
    //            return false;
    //        }
    //        if (isNaN(mobile)) {
    //    document.getElementById('mobileerror').innerHTML = "*  mobile number must contain numeric values only ";
    //            return false;
    //        }
    //        if (email == "") {
    //    document.getElementById('emailerror').innerHTML = "* please fill in the email id";
    //            return false;
    //        }
    //        if (email.indexOf('@')<=0) {
    //    document.getElementById('emailerror').innerHTML = "* invalid email";
    //            return false;
    //        }
    //        if ((email.charAt(email.length - 4) != ".") || (email.charAt(email.length - 3) != ".")){
    //    document.getElementById('emailerror').innerHTML = "* invalid mail format";
    //            return false;
    //        }
    //        return true;
    //    }


function validate(semail)
{
    if (semail.indexOf('@') <= 0) {
        return false;
    }
    if ((semail.charAt(semail.length - 4) != ".") && (semail.charAt(semail.length - 3) != ".")) {
        return false;
    }
    else {
        return true;
    }
}