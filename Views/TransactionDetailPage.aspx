<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="MakeMeUpzz.Views.TransactionDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content_page" runat="server">
    <h1>Transaction Detail Page</h1>
    <hr />

    <div style="padding: 10px">
        <table style="width: 800px">
            <tr>
                <td>Date</td>
                <td><%= transaction.TransactionDate %></td>
            </tr>
            <tr>
                <td>Buyer</td>
                <td><%= transaction.User.UserName %></td>
            </tr>
            <tr>
                <td>Total Product</td>
                <td><%= transaction.TransactionDetails.Count() %></td>
            </tr>
            <tr>
                <td>Total Quantity</td>
                <td><%= transaction.TransactionDetails.Sum(td => td.Quantity) %></td>

            </tr>
            <tr>
                <td>Total Type</td>
                <td><%= transaction.TransactionDetails.GroupBy(x => x.Makeup.MakeupTypeID).Count() %></td>
            </tr>
            <tr>
                <td>Total Money Spent</td>
                <td><%= transaction.User.TransactionHeaders.Sum(tran => tran.TransactionDetails.
                 Sum(x => x.Quantity * x.Makeup.MakeupPrice)) %></td>
            </tr>
            <tr>
                <td>Min Spending</td>
                <td><%= transaction.User.TransactionHeaders.Min(tran => tran.TransactionDetails.
                    Sum(x => x.Quantity * x.Makeup.MakeupPrice)) %></td>
            </tr>
            <tr>
                <td>Max Spending</td>
                <td><%= transaction.User.TransactionHeaders.Max(tran => tran.TransactionDetails.
                    Sum(x => x.Quantity * x.Makeup.MakeupPrice)) %></td>
            </tr>
            <tr>
                <td>Average Spending</td>
                <td><%= transaction.User.TransactionHeaders.Average(tran => tran.TransactionDetails.
                 Sum(x => x.Quantity * x.Makeup.MakeupPrice)) %></td>
            </tr>
        </table>

        <br />

        <table style="width: 850px" border="1">
            <tr>
                <th>Makeup</th>
                <th>Makeup Type</th>
                <th>Makeup Price</th>
                <th>Quantity</th>
                <th>Subtotal</th>
            </tr>

            <%foreach (var x in transaction.TransactionDetails) {%>
            <tr>
                <td><%= x.Makeup.MakeupName %></td>
                <td><%= x.Makeup.MakeupType.MakeupTypeName %></td>
                <td><%= x.Makeup.MakeupPrice %></td>
                <td><%= x.Quantity %></td>
                <td><%= x.Makeup.MakeupPrice * x.Quantity %></td>
            </tr>
            <%} %>
            <tr>
                <td colspan="4">Total</td>
                <td colspan="1"><%= transaction.TransactionDetails.Sum(x => x.Quantity * x.Makeup.MakeupPrice) %></td>
            </tr>
        </table>
    </div>
</asp:Content>
