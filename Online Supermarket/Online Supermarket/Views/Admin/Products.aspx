<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Online_Supermarket.Views.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
        <div class="container-fluid">
                <div class="row">
                        <div class="col">
                                <h3 class="text-center">Product Management</h3>
                        </div>
                </div>
                <div class="row">
                        <div class="col-md-4">
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Product Name</label>
                                        <input type="text" autocomplete="off" runat="server" id="PNameTb" class="form-control" />
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Manufacturer Name</label>
                                        <asp:DropDownList ID="PManufactCb" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Category</label>
                                        <asp:DropDownList ID="PCateCb" runat="server" class="form-control"></asp:DropDownList>

                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Price</label>
                                        <input type="text" autocomplete="off" runat="server" id="PPriceTb" class="form-control" />
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Quantity</label>
                                        <input type="text" autocomplete="off" runat="server" id="PQtyTb" class="form-control" />
                                </div>


                                <div class="row">
                                        <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>

                                        <div class="col-md-4">
                                                <asp:Button Text="Edit" runat="server" ID="EditBtn" Class="btn-warning btn-block btn" Width="78px" OnClick="EditBtn_Click" />
                                        </div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Save" runat="server" ID="SaveBtn" Class="btn-success btn-block btn " Width="78px" OnClick="SaveBtn_Click" />
                                        </div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Delete" runat="server" ID="DeleteBtn" Class="btn-danger btn-block btn" Width="78px" OnClick="DeleteBtn_Click" />
                                        </div>
                                </div>
                        </div>
                        <div class="col-md-8">
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
</asp:Content>
