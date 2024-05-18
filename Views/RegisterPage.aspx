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
            <asp:Label ID="NameLabel" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="UserNameBox" runat="server" Style="margin-left: 83px" Width="176px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="EmailLabel" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="EmailBox" runat="server" Style="margin-left: 124px" Width="176px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="GenderLabel" runat="server" Text="Gender : "></asp:Label>
            <asp:DropDownList ID="GenderDropDownList" runat="server" Style="margin-left: 104px" Width="185px">
                <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="PasswordBox" runat="server" Style="margin-left: 86px" Width="179px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ConfPasswordLabel" runat="server" Text="Confirm Password : "></asp:Label>
            <asp:TextBox ID="ConfPasswordBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="DobLabel" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="Calendar" runat="server" Height="196px" Style="margin-bottom: 0px" Width="382px"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div>
    </form>
</body>
</html>
