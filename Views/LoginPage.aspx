<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MakeMeUpzz.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MakeMeUpzz</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <hr />
        <div>
            <asp:Label ID="UserNameLabel" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="UserNameBox" runat="server" Width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password" style="margin-left: 5px" Width="195px"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberBox" runat="server" />
            <asp:Label ID="RememberLabel" runat="server" Text="Remember Me"></asp:Label>
        </div>
        <div>
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="LoginButton" runat="server" Text="Login" Width="318px" OnClick="login_btn_Click" />
        </div>
    </form>
</body>
</html>
