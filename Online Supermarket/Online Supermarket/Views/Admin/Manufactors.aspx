<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Manufactors.aspx.cs" Inherits="Online_Supermarket.Views.Admin.Suppliers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
        <div class="container-fluid">
                <div class="row">
                        <div class="col">
                                <h3 class="text-center">Manufacturer Management</h3>
                        </div>
                </div>
                <div class="row">
                        <div class="col-md-4">
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Manufacturer Name</label>
                                        <input type="text" autocomplete="off" class="form-control" runat="server" id="MNameTb"/>
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Production License Number</label>
                                        <input type="text" autocomplete="off" class="form-control" runat="server" id="ProdNumTb"/>
                                </div>
                                <div class="mb-3">
                                        <label for="" class="form-lable text-success">Place of Origin</label>
                                        <asp:DropDownList ID="PlaceCb" runat="server" class="form-control">
                                                <asp:ListItem>New Zealand</asp:ListItem>
                                                <asp:ListItem>Australia</asp:ListItem>
                                                <asp:ListItem>China</asp:ListItem>
                                                <asp:ListItem>Fiji</asp:ListItem>
                                                <asp:ListItem>Japan</asp:ListItem>

                                        </asp:DropDownList>

                                </div>
                                <div class="row">
                                        <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                                        <div class="col-md-4">
                                                <asp:Button Text="Edit" runat="server" id="EditBtn" Class="btn-warning btn-block btn" Width="78px" OnClick="EditBtn_Click" />
                                        </div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Save" runat="server" id="SaveBtn" Class="btn-success btn-block btn " Width="78px" OnClick="SaveBtn_Click" />
                                        </div>
                                        <div class="col-md-4">
                                                <asp:Button Text="Delete" runat="server" id="DeleteBtn" Class="btn-danger btn-block btn" Width="78px" OnClick="DeleteBtn_Click" />
                                        </div>
                                </div>
                        </div>
                        <div class="col-md-8">
                                <asp:GridView ID="ManufactList" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" Width="645px" OnSelectedIndexChanged="ManufactList_SelectedIndexChanged">
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
</asp:Content>
