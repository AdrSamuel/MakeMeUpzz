<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="OrderQueuePage.aspx.cs" Inherits="MakeMeUpzz.Views.AdminViews.OrderQueuePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">

    <h1>Order Queue</h1>
    <hr />

    <div>
        <h2>Unhandled</h2>
        <asp:GridView ID="UnhandledGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:TemplateField HeaderText="Handle Transaction">
                    <ItemTemplate>
                        <asp:Button ID="HandleButton" runat="server" Text="Handle" OnClick="HandleButton_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
    <br />
    <div>
        <h2>Handled</h2>
        <asp:GridView ID="HandledGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            </Columns>

        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="HistoryLabel" runat="server" Text="Show Transaction History : "></asp:Label>
        <asp:Button ID="HistoryButton" runat="server" Text="Show Me!" OnClick="HistoryButton_Click" />
    </div>

</asp:Content>
