<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="MakeMeUpzz.Views.UpdateProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Update</h1>
    <hr />
    <div>
        <asp:Label ID="UserNameLabel" runat="server" Text="Username : "></asp:Label>
        <asp:TextBox ID="UserNameBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="UserEmailLabel" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="UserEmailBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="UserGenderLabel" runat="server" Text="Gender : "></asp:Label>
        <asp:DropDownList ID="UserGenderDropDownList" runat="server" Style="margin-left: 104px" Width="185px">
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="UserDobLabel" runat="server" Text="Date of birth : "></asp:Label>
        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
    </div>
</asp:Content>
