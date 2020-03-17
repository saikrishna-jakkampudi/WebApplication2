<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script lang="JavaScript" type="text/Javascript">

        function Validate() {
            var eno = document.getElementById("txtEno").value;
            var ename = document.getElementById("txtEname").value;
            var job = document.getElementById("txtJob").value;
            var mgr = document.getElementById("txtManagerID").value;
            var hd = document.getElementById("txtHireDate").value;
            var sal = document.getElementById("txtSal").value;
            var comm = document.getElementById("txtCommission").value;
            var dno = document.getElementById("txtDeptno").value;

        if
        
         (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
            return true;
        
        else
        {
            alert("Enter all Details");
            return false;
        }
      
       
    }

   </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 500px">
                <tr>
                    <td>Employee No</td>
                    <td>
                        <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Name</td>
                    <td>
                        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Job</td>
                    <td>
                        <asp:TextBox ID="txtJob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manager ID</td>
                    <td>
                        <asp:TextBox ID="txtManagerID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>HireDate</td>
                    <td>
                        <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Sal</td>
                    <td>
                        <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Commission</td>
                    <td>
                        <asp:TextBox ID="txtCommission" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Deptno</td>
                    <td>
                        <asp:TextBox ID="txtDeptno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClientClick=" return Validate()" OnClick="btnSubmit_Click"/>
    </form>
</body>
</html>
