<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Extract.aspx.cs" Inherits="WebApplication2.Extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2> 
        
        Enter the Deptno :<asp:DropDownList ID="DDDEPT" runat="server" OnSelectedIndexChanged="DDDEPT_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
            <asp:ListItem Value="-1">Select</asp:ListItem>
        </asp:DropDownList>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </h2>
</asp:Content>
