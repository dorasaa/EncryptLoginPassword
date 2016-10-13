<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPassword.aspx.cs" Inherits="EncryptLoginPassword.TestPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Password" ToolTip=" "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="lblmsg1" runat="server"></asp:Label>
    </div>
    </form>
</body>

</html>
