<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="DeleteEmp.aspx.cs" Inherits="WebApplication2.DeleteEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/DeleteEmpValidations.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <table style="width: 500px">
                <tr>
                    <td>Employee No</td>
                    <td>
                        <asp:TextBox ID="txtEno" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
             <tr> 
                 <td>&nbsp;</td>
                 <td>
                     <asp:Button ID="btDelete" runat="server" Text="Delete" OnClick="btDelete_Click" OnClientClick="return DeleteValidate()"/>
                 </td>
                    
                </tr>
            </table>
    <asp:Label ID="msg" runat="server" Text=""></asp:Label>

</asp:Content>
