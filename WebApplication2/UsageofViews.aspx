<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="UsageofViews.aspx.cs" Inherits="WebApplication2.UsageofViews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px"></asp:DetailsView>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" OnPageIndexChanging="FormView1_PageIndexChanging" >
        <ItemTemplate>
            <table style="width:100%;border-collapse:collapse" border ="1">
               
                <tr>
                    <td>OrderID</td>
                    <td>OrderDesc</td>
                    <td>TotalCost</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Orderid") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("OrderDesc") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("TotalCost") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    
</asp:Content>
