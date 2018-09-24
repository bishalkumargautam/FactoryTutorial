<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FactoryMethod.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
           username <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></p>
        <p>
         Password  <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox> </p>
        <asp:Button ID="btnSignin" runat="server" Text="Login" OnClick="btnSignin_Click" />
    </form>
</body>
</html>
