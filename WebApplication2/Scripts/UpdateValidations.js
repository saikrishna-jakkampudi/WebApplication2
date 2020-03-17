function UpdateeValidate()

{


    var eno = document.getElementById("txtEno").value;
    var str = new String("Enter Employee No");


    if (eno.length != 0)
        return true;
    else

        alert(str);
       
    return false;


}