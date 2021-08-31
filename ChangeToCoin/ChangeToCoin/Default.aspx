<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChangeToCoin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        What is the amount of change that you would like to convert to coins?&nbsp;
        <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="convertButton" runat="server" OnClick="convertButton_Click" Text="Convert" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
