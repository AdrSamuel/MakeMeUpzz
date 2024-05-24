<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="InsertMakeup.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.InsertMakeup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
   
    <h1>Insert Makeup</h1>
    <hr />

    <div>
        <asp:Label ID="NameLabel" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="PriceLabel" runat="server" Text="Price : "></asp:Label>
        <asp:TextBox ID="PriceBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="WeightLabel" runat="server" Text="Weight : "></asp:Label>
        <asp:TextBox ID="WeightBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="TypeLabel" runat="server" Text="Type ID : "></asp:Label>
        <asp:TextBox ID="TypeBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="BrandLabel" runat="server" Text="Brand ID : "></asp:Label>
        <asp:TextBox ID="BrandBox" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" />
        <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />
    </div>
       
</asp:Content>
