<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 200px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body style="height: 673px">
    <form id="form1" runat="server">
        <div>
        </div>
    <p><img alt="papabob" class="auto-style1"  src="file:///C:/Users/Blaise/source/repos/ChallengeFirstPapaBobsWebsite/PapaBob.png" />
    <h1>Papa Bob's Pizza and Software</h1></p>

        <div class="restOfForm">

            <asp:RadioButton ID="pizzaSizeRadioButton1" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="pizzaSizeRadioButton2" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
            <br />
            <asp:RadioButton ID="pizzaSizeRadioButton3" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16" />
            <br />
            <br />
            <asp:RadioButton ID="crustTypeRadioButton1" runat="server" GroupName="crustType" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="crustTypeRadioButton2" runat="server" GroupName="crustType" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
            <br />
            <br />
            <strong><span class="auto-style2">Papa Bob&#39;s <span class="auto-style3">Special Deal</span></span></strong><br />
            <br />
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Purchase" OnClick="Button1_Click" />
            <br />
            <br />
            Total:
            <asp:Label ID="orderTotalLabel" runat="server" Text="$0.00"></asp:Label>
            <br />
            <br />
            Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</div>
    </form>
    
</body>
</html>
