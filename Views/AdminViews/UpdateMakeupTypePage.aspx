<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupTypePage.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.UpdateMakeupTypePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Update Makeup Type</h1>
    <hr />

    <div>
        <asp:Label ID="NameLabel" runat="server" Text="Type Name : "></asp:Label>
        <asp:TextBox ID="TypeNameBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
    </div>
</asp:Content>
