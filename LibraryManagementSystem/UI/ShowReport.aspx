<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowReport.aspx.cs" Inherits="LibraryManagementSystem.UI.ShowReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="reportGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MemberNumber" HeaderText="Member Number" />
                <asp:BoundField DataField="MemberName" HeaderText="Member Name" />
                <asp:HyperLinkField
            DataNavigateUrlFields="MemberNumber"
            DataNavigateUrlFormatString="ViewBooks.aspx?MemberNumber={0}"
            DataTextField="NoOfBookNotReturned"
            HeaderText="No of Books not Return" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

