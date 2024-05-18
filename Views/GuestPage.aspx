<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestPage.aspx.cs" Inherits="MakeMeUpzz.Views.GuestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MakeMeUpzz</title>
</head>
<body style="text-align: center; position: absolute; top: 20%; left: 50%; transform: translate(-50%, -50%);">
    <form id="form1" runat="server">
        <div>
            <h1>MakeMeUpzz</h1>
            <hr />
            <div>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Views/RegisterPage.aspx">Register</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Views/LoginPage.aspx">Login</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
