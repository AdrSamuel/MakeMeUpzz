<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrand.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.InsertMakeupBrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    
        <h1>Insert Makeup Brand</h1>
        <hr />

        <div>
            <asp:Label ID="BrandNameLabel" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="BrandNameBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="RatingLabel" runat="server" Text="Rating : "></asp:Label>
            <asp:TextBox ID="RatingBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" Style="height: 35px" />
            <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />
        </div>
    

</asp:Content>
