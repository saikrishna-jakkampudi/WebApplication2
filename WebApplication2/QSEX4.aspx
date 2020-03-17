<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QSEX4.aspx.cs" Inherits="WebApplication2.QSEX4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="JavaScript" type="text/javascript">
        function dunc1()
        {
            //window.location.href = "QsEX5.aspx";

            window.open("QsEX5.aspx?A=10&B=20");
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="dunc1()" />
        </div>
    </form>
</body>
</html>
