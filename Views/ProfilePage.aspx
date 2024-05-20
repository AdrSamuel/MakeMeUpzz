<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="MakeMeUpzz.Views.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Profile</h1>
    <hr />
    <div>
        <asp:GridView ID="ProfileGV" runat="server" AutoGenerateColumns="False" OnRowEditing="ProfileGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Username" SortExpression="UserName" />
                <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                <asp:BoundField DataField="UserDOB" HeaderText="Date of Birth" SortExpression="UserDOB" />
                <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                <asp:CommandField ButtonType="Button" HeaderText="Command" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <h2>Change Password</h2>
    <hr />
    <div>
        <asp:Label ID="OldPasswordLabel" runat="server" Text="Old Password : "></asp:Label>
        <asp:TextBox ID="OldPasswordBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="NewPasswordLabel" runat="server" Text="New Password : "></asp:Label>
        <asp:TextBox ID="NewPasswordBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="UpdatePasswordButton" runat="server" Text="Update Password" OnClick="UpdatePasswordButton_Click" />
    </div>
</asp:Content>
