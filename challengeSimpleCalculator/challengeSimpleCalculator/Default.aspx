<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                First Value:&nbsp;
                <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Second Value:&nbsp;
                <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="addButton" runat="server" Height="25px" OnClick="addButton_Click" Text="+" Width="25px" />
&nbsp;
                <asp:Button ID="subtractButton" runat="server" Height="25px" OnClick="subtractButton_Click" Text="-- " Width="25px" />
&nbsp;
                <asp:Button ID="multiplyButton" runat="server" Height="25px" OnClick="multiplyButton_Click" Text="*" Width="25px" />
&nbsp;
                <asp:Button ID="divideButton" runat="server" Height="25px" OnClick="divideButton_Click" Text="/" Width="25px" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
