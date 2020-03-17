
function Validate()
{
    var eno = document.getElementById("txtEno").value;
    var ename = document.getElementById("txtEname").value;
    var job = document.getElementById("txtJob").value;
    var mgr = document.getElementById("txtManagerID").value;
    var hd = document.getElementById("txtHireDate").value;
    var sal = document.getElementById("txtSal").value;
    var comm = document.getElementById("txtCommission").value;
    var dno = document.getElementById("txtDeptno").value;
    if(eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
        return true;
else

    alert("Enter all Details");
    return false;


}
