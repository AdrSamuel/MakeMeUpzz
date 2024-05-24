<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Header.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.CustomerViews.OrderMakeupPage" %>

<asp:Content ID="OrderMakeupContent" ContentPlaceHolderID="content_page" runat="server">
    
    <h1>Order Makeup</h1>
    <hr />
    <div>
        <h2>View Makeup</h2>
        <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="False" DataKeyNames="MakeupID">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeUpName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeUpPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight in grams" SortExpression="MakeUpWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Makeup Type" SortExpression="MakeupTypes.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Makeup Brand" SortExpression="MakeupBrands.MakeupBrandName" />
                <asp:TemplateField HeaderText="Add To Cart">
                    <ItemTemplate>
                        <asp:TextBox ID="QuantityBox" runat="server" placeholder="Input Quantity"></asp:TextBox>
                        <asp:Button ID="OrderButton" runat="server" Text="Order" OnClick="OrderButton_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <h2>Cart</h2>
        <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
            
        </asp:GridView>
        <asp:Label ID="CartStatus" runat="server" Text=""></asp:Label>
        <br />
        <div id="CartButton" runat="server">
            <asp:Button ID="ClearCartButton" runat="server" Text="Clear Cart" OnClick="ClearCartButton_Click" />
            <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />
        </div>
    </div>
    

</asp:Content>
    