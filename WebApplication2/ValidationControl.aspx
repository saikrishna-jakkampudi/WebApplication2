<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="ValidationControl.aspx.cs" Inherits="WebApplication2.ValidationControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
               <td>
                   Empno
            </td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Cannot Be Blank" ControlToValidate="TextBox1" ForeColor="#FF3300" Display="Dynamic"></asp:RequiredFieldValidator>

            </td>
            </tr>
        <tr>
            <td>
                Ename
            </td>
            
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Cannot Be Blank" ControlToValidate="TextBox2" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

            </td>
            </tr>
        <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>confirm password</td>
            <td> <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>  </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Doesnt Match" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                Salary
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter Salary Between 10000  and 200000" Type="Double" MaximumValue="200000" MinimumValue="10000" ControlToValidate="TextBox5" ForeColor="Red" Display="Dynamic"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                    Pancard
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Valid Pancard No" ControlToValidate="TextBox6" ForeColor="Red" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
       
        <td>
            Date Of Birth

        </td>
        <td>
            <asp:TextBox ID="TextBox7" TextMode="Date" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Age Must be in between 21-58" Display="Dynamic" ControlToValidate="TextBox7" Enabled="True" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </td>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> 

            </td>
        </tr>

    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" BorderStyle="Dotted" ForeColor="Red" />
</asp:Content>
