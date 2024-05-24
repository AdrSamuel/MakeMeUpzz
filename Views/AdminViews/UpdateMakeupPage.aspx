<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.UpdateMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Update Makeup</h1>
    <hr />

    <div>
        <asp:Label ID="MakeupNameLabel" runat="server" Text="Makeup Name : "></asp:Label>
        <asp:TextBox ID="MakeupNameBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="MakeupPriceLabel" runat="server" Text="Makeup Price : "></asp:Label>
        <asp:TextBox ID="MakeupPriceBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="MakeupWeightLabel" runat="server" Text="Makeup Weight : "></asp:Label>
        <asp:TextBox ID="MakeupWeightBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="TypeIDLabel" runat="server" Text="Makeup Type ID : "></asp:Label>
        <asp:TextBox ID="MakeupTypeIDBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="BrandLabel" runat="server" Text="Makeup Brand ID : "></asp:Label>
        <asp:TextBox ID="MakeupBrandIDBox" runat="server"></asp:TextBox>
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
