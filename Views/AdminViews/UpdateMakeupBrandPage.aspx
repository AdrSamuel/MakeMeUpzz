<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrandPage.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.UpdateMakeupBrandPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Update Makeup Brand</h1>
    <hr />

    <div>
        <asp:Label ID="BrandNameLabel" runat="server" Text="Brand Name : "></asp:Label>
        <asp:TextBox ID="BrandNameBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="BrandRatingLabel" runat="server" Text="Brand Rating : "></asp:Label>
        <asp:TextBox ID="BrandRatingBox" runat="server"></asp:TextBox>
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
