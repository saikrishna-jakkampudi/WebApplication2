function LoginValidate()
{
    var Username = document.getElementById("txtUsername").value;
    var Password = document.getElementById("txtPassword").value;

    if (Username.length == 0 || Password.length== 0)
    {
        alert('Enter Username / Password');
        return false;
    }

    else
        return true;
}