<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBookUI.aspx.cs" Inherits="LibraryManagementSystem.UI.ReturnBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Enter Member No.
            </td>
            <td>
                <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="showBorrowedBookListButton" runat="server" Text="Show Borrowed Books" OnClick="showBorrowedBookListButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
                Borrowed Book List
            </td>
            <td>
                <asp:DropDownList ID="bookDropDownList" runat="server" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="returnButton" runat="server" Text="Return" OnClick="returnButton_Click" /><asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
