<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="MakeMeUpzz.Views.TransactionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Transaction Page</h1>
    <hr />
     
    <div style="padding: 50px" ID="AdminView" runat="server">
        <h2>All Transactions</h2>
        <br />
        <table style="width: 500px; text-align: center;" border="1">
            <tr>
                <th style="white-space: nowrap;">Transaction ID</th>
                <th style="white-space: nowrap;">User ID</th>
                <th style="white-space: nowrap;">Date</th>
                <th style="white-space: nowrap;">Status</th>
                <th style="white-space: nowrap;">TotalProduct</th>
                <th style="white-space: nowrap;">View Details</th>
            </tr>

            <%foreach (var x in allTransactions) {%>
            <tr>
                <td style="white-space: nowrap;"><%=x.TransactionID %></td>
                <td style="white-space: nowrap;"><%=x.UserID %></td>
                <td style="white-space: nowrap;"><%=x.TransactionDate %></td>
                <td style="white-space: nowrap;"><%=x.Status %></td>
                <td style="white-space: nowrap;"><%=x.TransactionDetails.Count() %></td>
                <td style="white-space: nowrap;"><a href="TransactionDetailPage.aspx?id=<%=x.TransactionID %>">View Detail</a></td>
            </tr>
            <% } %>
        </table>
    </div>


    <div style="padding: 50px" ID="CustomerView" runat="server">
    <h2>Your Transactions</h2>
    <br />
    <table style="width: 500px; text-align: center;" border="1">
        <tr>
            <th style="white-space: nowrap;">Transaction ID</th>
            <th style="white-space: nowrap;">Username</th>
            <th style="white-space: nowrap;">Date</th>
            <th style="white-space: nowrap;">Status</th>
            <th style="white-space: nowrap;">TotalProduct</th>
            <th style="white-space: nowrap;">View Details</th>
        </tr>

        <%foreach (var x in userTransactions) {%>
        <tr>
            <td style="white-space: nowrap;"><%=x.TransactionID %></td>
            <td style="white-space: nowrap;"><%=x.User.UserName %></td>
            <td style="white-space: nowrap;"><%=x.TransactionDate %></td>
            <td style="white-space: nowrap;"><%=x.Status %></td>
            <td style="white-space: nowrap;"><%=x.TransactionDetails.Count() %></td>
            <td style="white-space: nowrap;"><a href="TransactionDetailPage.aspx?id=<%=x.TransactionID %>">View Detail</a></td>
        </tr>
        <% } %>
    </table>
</div>


</asp:Content>
