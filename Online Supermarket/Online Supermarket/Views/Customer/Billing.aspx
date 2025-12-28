<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="Online_Supermarket.Views.Customer.Billing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
        <div class="container-fluid">
                <div class="row">
                </div>
                <div class="row">
                        <div class="col-md-5">
                                <h3 class="text-center">Shop Products</h3>
                                <div class="row">
                                        <div class="col">
                                                <div class="mt-3">
                                                        <label for="" class="form-lable text-success">Product Name</label>
                                                        <input type="text" placeholder="" autocomplete="off" class="form-control" runat="server" id="PNameTb" />
                                                </div>
                                        </div>
                                        <div class="col">
                                                <div class="mt-3">
                                                        <label for="" class="form-lable text-success">Price</label>
                                                        <input type="text" placeholder="" autocomplete="off" class="form-control" runat="server" id="PriceTb" />
                                                </div>
                                        </div>
                                        <div class="col">
                                                <div class="mt-3">
                                                        <label for="" class="form-lable text-success">Amount</label>
                                                        <input type="text" placeholder="" autocomplete="off" class="form-control" runat="server" id="QtyTb" />
                                                </div>
                                        </div>
                                        <div class="row">
                                                <div class="col">
                                                         <asp:Button Text="Add to cart" runat="server" ID="AddToBillBtn" Class="btn-warning btn-block btn" OnClick="AddToBillBtn_Click" />
                                                </div>
                                        </div>

                                </div>
                                <div class="row mt-5">
                                        <h4 class="text-center">Products List</h4>
                                        <div class="col">
                                                <asp:GridView ID="ProductList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="645px" OnSelectedIndexChanged="ProductList_SelectedIndexChanged">
                                                        <AlternatingRowStyle BackColor="White" />
                                                        <EditRowStyle BackColor="#7C6F57" />
                                                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="teal" Font-Bold="False" ForeColor="White" />
                                                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#E3EAEB" />
                                                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                                                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                                                </asp:GridView>
                                        </div>
                                </div>
                        </div>
                        <div class="col-md-7">
                                <h4 class="text-center">Shopping Cart</h4>
                                <div class="col">
                                        <asp:GridView ID="ShoppingCartList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="645px" OnSelectedIndexChanged="ProductList_SelectedIndexChanged">
                                                <AlternatingRowStyle BackColor="White" />
                                                <EditRowStyle BackColor="#7C6F57" />
                                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="teal" Font-Bold="False" ForeColor="White" />
                                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#E3EAEB" />
                                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                                <SortedAscendingHeaderStyle BackColor="#246B61" />
                                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                                        </asp:GridView>
                                        <div class="d-grid">
                                                <asp:Button Text="Check Out" runat="server" ID="PrintBtn" Class="btn-warning btn-block btn" />
                                        </div>
                                </div>
                        </div>
                </div>
        </div>
</asp:Content>
