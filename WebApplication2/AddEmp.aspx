<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="AddEmp.aspx.cs" Inherits="WebApplication2.AddEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/AddEmpValidations.js"></script>
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
                    <td>Employee Name</td>
                    <td>
                        <asp:TextBox ID="txtEname" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Job</td>
                    <td>
                        <asp:TextBox ID="txtJob" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manager ID</td>
                    <td>
                        <asp:TextBox ID="txtManagerID" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>HireDate</td>
                    <td>
                        <asp:TextBox ID="txtHireDate"  ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Sal</td>
                    <td>
                        <asp:TextBox ID="txtSal" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Commission</td>
                    <td>
                        <asp:TextBox ID="txtCommission" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Deptno</td>
                    <td>
                        <asp:TextBox ID="txtDeptno" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
              
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnClientClick="return Validate()" /> 
                        <asp:Button ID="Button3" runat="server" Text="Insert With SP" OnClick="Button3_Click" />
                    </td>
            
      
                        </tr>
            </table>
    <asp:Label ID="msg" runat="server" Text="I"></asp:Label>

</asp:Content>
