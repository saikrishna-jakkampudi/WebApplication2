<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpages.aspx.cs" Inherits="WebApplication2.Loginpages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table class="auto-style12">
        <tr>
            <td class="auto-style14" >UserId</td>
            <td class="auto-style15" >
                <asp:TextBox ID="txtUsername" runat="server" ClientIDMode="Static"   ></asp:TextBox></td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ControlToValidate="txtUsername"  ID  ="RequiredFieldValidator1" runat="server" ErrorMessage="Username cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style16">Password</td>
            <td class="auto-style17">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ClientIDMode="Static" ></asp:TextBox></td>
        <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Cannot be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

            </td>

        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="58px" OnClick="btnLogin_Click"  />
            </td>
        </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
