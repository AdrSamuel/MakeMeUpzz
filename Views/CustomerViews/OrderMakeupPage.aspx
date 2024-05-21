<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.CustomerViews.OrderMakeupPage" %>

<asp:Content ID="OrderMakeupContent" ContentPlaceHolderID="content_page" runat="server">
    <h1>Order Makeup</h1>
    <hr />
    <div>
        <h2>View Makeup</h2>
        <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeUpName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeUpPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight in grams" SortExpression="MakeUpWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Makeup Type" SortExpression="MakeupTypes.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Makeup Brand" SortExpression="MakeupBrands.MakeupBrandName" />
                <asp:TemplateField HeaderText="Add To Cart">
                    <ItemTemplate>
                        <asp:TextBox ID="QuantityBox" runat="server" placeholder="Input Quantity"></asp:TextBox>
                        <asp:Button ID="OrderButton" runat="server" Text="Order" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <h2>Cart</h2>

    </div>

</asp:Content>
