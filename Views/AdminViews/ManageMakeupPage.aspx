<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.ManageMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Manage Makeup</h1>
    <hr />
    <div>
        <h2>Makeup List</h2>
        <hr />
        <div>
            <asp:Label ID="InsertMakeupLabel" runat="server" Text="Insert Makeup : "></asp:Label>
            <asp:Button ID="InserMakeupButton" runat="server" Text="Insert" />
        </div>
        <br />
        <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="Makeup ID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Makeup Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Makeup Weight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupTypeID" HeaderText="Makeup Type ID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupBrandID" HeaderText="Makeup Brand ID" SortExpression="MakeupBrandID" />
                <asp:CommandField ButtonType="Button" HeaderText="Commands" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <div>
        <h2>Makeup Type List</h2>
        <hr />
        <div>
            <asp:Label ID="InsertMakeupTypeLabel" runat="server" Text="Insert Makeup Type : "></asp:Label>
            <asp:Button ID="InsertMakeupTypeButton" runat="server" Text="Insert" />
        </div>
        <br />
        <asp:GridView ID="MakeupTypeGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="Makeup Type ID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupTypeName" HeaderText="Makeup Type Name" SortExpression="MakeupTypeName" />
                <asp:CommandField ButtonType="Button" HeaderText="Commands" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <div>
        <h2>Makeup Brand List</h2>
        <hr />
        <div>
            <asp:Label ID="InsertMakeupBrandLabel" runat="server" Text="Insert Makeup Brand : "></asp:Label>
            <asp:Button ID="InsertMakeupBrandButton" runat="server" Text="Insert" />
        </div>
        <br />
        <asp:GridView ID="MakeupBrandGV" runat="server" AutoGenerateColumns="False" style="margin-top: 0px">
            <Columns>
                <asp:BoundField DataField="MakeupBrandID" HeaderText="Makeup Brand ID" SortExpression="MakeupBrandID" />
                <asp:BoundField DataField="MakeupBrandName" HeaderText="Makeup Brand Name" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="Makeup Brand Rating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ButtonType="Button" HeaderText="Commands" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>
