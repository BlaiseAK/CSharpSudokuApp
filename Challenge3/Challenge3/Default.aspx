<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="noteTaking" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="noteTaking" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="noteTaking" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="noteTaking" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
