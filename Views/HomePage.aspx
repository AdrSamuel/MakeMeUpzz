<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MakeMeUpzz.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Home Page</h1>
    <hr />
    <div>
        <asp:Label ID="UserNameLabel" runat="server" Text="Username : "></asp:Label>
        <asp:Label ID="UserNameShow" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="UserRoleLabel" runat="server" Text="Role : "></asp:Label>
        <asp:Label ID="UserRoleShow" runat="server" Text=""></asp:Label>
    </div>
    <div id="ListUserContainer" runat="server">
        <h1>List User</h1>
        <asp:GridView ID="ListUserGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserId" />
                <asp:BoundField DataField="UserName" HeaderText="User Name" SortExpression="UserName" />
                <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                <asp:BoundField DataField="UserDOB" HeaderText="Date Of Birth" SortExpression="UserDOB" />
                <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
