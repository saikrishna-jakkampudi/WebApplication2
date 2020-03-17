<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="WebApplication2.Confirm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 284px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Eno</td>
            <td class="auto-style2">
                <asp:Label ID="Eno" runat="server" Text="Label"></asp:Label> 

            </td>
            </tr>
        <tr>
             <td>Enmae</td>
            <td class="auto-style2">
                <asp:Label ID="Ename" runat="server" Text="Label"></asp:Label> 

            </td>
            </tr>
           <tr>
             <td>Job</td>
            <td class="auto-style2">
                <asp:Label ID="Job" runat="server" Text="Label"></asp:Label> 
            </td>
                  </tr>
           <tr>
                 <td>Hiredate</td>
            <td class="auto-style2">
                <asp:Label ID="HD" runat="server" Text="Label"></asp:Label> 
            </td>
                  </tr>
        <tr>
                 <td>Mgr</td>
            <td class="auto-style2">
                <asp:Label ID="Mgr" runat="server" Text="Label"></asp:Label> 
            </td>
            </tr>
        <tr>
                 <td>Sal</td>
            <td class="auto-style2">
                <asp:Label ID="Sal" runat="server" Text="Label"></asp:Label> 

            </td>
            </tr>
                <tr>
                 <td>Comm</td>
            <td class="auto-style2">
                <asp:Label ID="Com" runat="server" Text="Label"></asp:Label> 
            </td>
        </tr>
        <tr>
                 <td>Deptno</td>
            <td class="auto-style2">
                <asp:Label ID="Dptno" runat="server" Text="Label"></asp:Label> 
            </td>
        </tr>
        <tr>
                 <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
