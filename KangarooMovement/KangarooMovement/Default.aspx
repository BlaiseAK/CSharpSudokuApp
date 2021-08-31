<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KangarooMovement.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How far would the Kangaroo go?&nbsp;
            <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="GO" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
