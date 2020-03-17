function DeleteValidate()
{
    var eno = document.getElementById("txtEno").value;
  
    if (eno.length != 0)
        return true;
    else

        alert("Enter Employee No");
    return false;


}
