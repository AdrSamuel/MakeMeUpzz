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
            <asp:Label ID="Label1" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 5px" Width="195px"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="remember_box" runat="server" />
            <asp:Label ID="remember_lab" runat="server" Text="Remember Me"></asp:Label>
        </div>
        <div>
            <asp:Label ID="error_lab" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="submit_btn" runat="server" Text="Submit" Width="318px" />
        </div>
    </form>
</body>
</html>
