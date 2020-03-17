<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="Scripts/LoginValidations.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 35px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 196px;
            height: 133px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<table border-spacing:55px;" class="auto-style3">


    <tr>


        <td>   Username   </td>

        <td>   <asp:TextBox ID="txtUsername" runat="server" ClientIDMode="Static"></asp:TextBox>    </td>

    </tr>

    <tr>



        <td class="auto-style1">   Password         </td>

          <td class="auto-style1">   <asp:TextBox ID="txtPassword" runat="server" ClientIDMode="Static" TextMode="Password"></asp:TextBox>         </td>


    </tr>


    <tr>
        
        
        <td> </td>

        <td>  <asp:Button ID="btLogin" runat="server" Text="Submit" align ="center" OnClick="btLogin_Click" OnClientClick="return LoginValidate();"/>  </td>


    </tr>


    <tr>
        <td>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        </td>
    </tr>
    <tr>
        <td>&nbsp</td>
        <td> <asp:Button ID="btSubmit" runat="server" Text="Submit" /></td>
    </tr>

</table>

</asp:Content>
