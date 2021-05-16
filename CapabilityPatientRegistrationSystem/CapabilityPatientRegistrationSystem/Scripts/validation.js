function ValidatePatientName(name) {
    if (name.length < 3) { return false; }
    for (var i = 0; i < name.length; i++) {
        if (!((name.charAt >= 'a' && name.charAt <= 'z') || (name.charAt >= 'A' && name.charAt <= 'Z')))
        {

            return false;
        }
        return true;
    }
}