<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MakeMeUpzz.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MakeMeUpzz</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <hr />
        <div>
            <asp:Label ID="username_lab" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="username_box" runat="server" style="margin-left: 83px" Width="176px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="email_lab" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="email_box" runat="server" style="margin-left: 124px" Width="176px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="gender_lab" runat="server" Text="Gender : "></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="pass_lab" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="pass_box" runat="server" style="margin-left: 86px" Width="179px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="conf_pass_lab" runat="server" Text="Confirm Password : "></asp:Label>
            <asp:TextBox ID="conf_pass_box" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="dob_lab" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" Height="196px" style="margin-bottom: 0px" Width="382px"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="error_lab" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="submit_btn" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
