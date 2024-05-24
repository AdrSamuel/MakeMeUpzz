<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="InsertMakeupType.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.InsertMakeupType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    
        <h1>Insert Makeup Type</h1>
        <hr />

        <div>
            <asp:Label ID="TypeNameLabel" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="TypeNameBox" runat="server"></asp:TextBox>
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
