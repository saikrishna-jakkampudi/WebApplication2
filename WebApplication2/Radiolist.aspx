<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Radiolist.aspx.cs" Inherits="WebApplication2.Radiolist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <table>

    <tr>
        <td>
        <asp:RadioButton ID="rdbHiredate" runat="server" GroupName="G1" Text="JoiningDate" OnCheckedChanged="rdbHiredate_CheckedChanged" AutoPostBack="True" />
        </td>
        <td>
            <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
        </td></tr>
    <tr><td>
        <asp:RadioButton ID="rdbDeptno" runat="server" GroupName="G1" Text="Department No" AutoPostBack="True" OnCheckedChanged="rdbDeptno_CheckedChanged" />
        </td><td>
            <asp:DropDownList ID="DDDEPTN" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDDEPTN_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select</asp:ListItem>
            </asp:DropDownList>
        </td></tr>
      <tr>
          <td>
              <asp:Button ID="Button1" runat="server" Text="Extract" OnClick="Button1_Click" />

          </td>

      </tr>

     

</table>

     <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>

    </asp:Content>
