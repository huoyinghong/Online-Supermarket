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
                                        <input type="text" autocomplete="off" class="form-control" />
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Manufacturer Name</label>
                                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Category</label>
                                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control"></asp:DropDownList>
                                        
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Price</label>
                                        <input type="text" autocomplete="off" class="form-control" />
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Quantity</label>
                                        <input type="text" autocomplete="off" class="form-control" />
                                </div>
                                <div class="row">
                                        <div class="col-md-4">
                                                <asp:Button Text="Edit" runat="server" Class="btn-warning btn-block btn" Width="78px" /></div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Save" runat="server" Class="btn-success btn-block btn " Width="78px"/></div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Delete" runat="server" Class="btn-danger btn-block btn" Width="78px"/></div>
        </div>
        </div>
                        <div class="col-md-8">
                                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        </div>
        </div>
        </div>
</asp:Content>
