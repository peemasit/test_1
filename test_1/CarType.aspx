<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarType.aspx.cs" Inherits="test_1.CarType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>Car ID</td>
            <td>
                <asp:TextBox ID="idTxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" onclick="addBtn_Click"/>
            </td>
        </tr>
    </table>
    <div _designerregion="0">
    </div>
</asp:Content>
