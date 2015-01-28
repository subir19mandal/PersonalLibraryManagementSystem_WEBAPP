<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBookUI.aspx.cs" Inherits="LibraryManagementSystem.UI.BorrowBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Enter Member No:</td>
            <td>
                <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Select A Book:</td>
            <td>
                <asp:DropDownList ID="bookDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="bookDropDownList_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Author:</td>
            <td>
                <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Publisher:</td>
            <td class="auto-style1">
                <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="borrowButton" runat="server" Text="Borrow" OnClick="borrowButton_Click" /><asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
