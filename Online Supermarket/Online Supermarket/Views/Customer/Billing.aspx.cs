using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Online_Supermarket.Views.Customer
{
        public partial class Billing : System.Web.UI.Page
        {
                Models.Functions Con;
                int customer = Login.User;
                string CName = Login.UName;
                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();
                        if (!IsPostBack)
                        {
                                ShowProducts();
                                DataTable dt = new DataTable();
                                dt.Columns.AddRange(new DataColumn[5]
                                {
                                        new DataColumn("Item No."),
                                        new DataColumn("Product Name"),
                                        new DataColumn("Price"),
                                        new DataColumn("Quantity"),
                                        new DataColumn("Total"),
                                });
                                ViewState["Bill"] = dt;
                                this.BindGrid();
                        }
                }

                private void BindGrid()
                {
                        ShoppingCartList.DataSource = ViewState["Bill"];
                        ShoppingCartList.DataBind();
                }

                private void ShowProducts()
                {
                        string Query = "Select PId,  PName, PQty, PPrice from ProductTb1";
                        ProductList.DataSource = Con.GetData(Query);
                        ProductList.DataBind();
                        ProductList.HeaderRow.Cells[1].Text = "Product ID";
                        ProductList.HeaderRow.Cells[2].Text = "Product Name";
                        ProductList.HeaderRow.Cells[3].Text = "Stock";
                        ProductList.HeaderRow.Cells[4].Text = "Price";
                }

                int key = 0;
                int stock = 0;
                protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        PNameTb.Value = ProductList.SelectedRow.Cells[2].Text;
                        stock = Convert.ToInt32(ProductList.SelectedRow.Cells[3].Text);
                        PriceTb.Value = ProductList.SelectedRow.Cells[4].Text;

                        if (PNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
                        }
                }

                private void UpdateStock()
                {
                        int NewQty;
                        NewQty = Convert.ToInt32(ProductList.SelectedRow.Cells[3].Text) - Convert.ToInt32(QtyTb.Value);
                        string Query = "update ProductTb1 set PQty='{0}' where Pid={1}";
                        Query = string.Format(Query, NewQty, ProductList.SelectedRow.Cells[1].Text);
                        Con.SetData(Query);
                        ShowProducts();

                }

                private void InsertBill()
                {
                        try
                        {
                                string Query = "insert into BillTb1 values('{0}','{1}','{2}') ";
                                Query = string.Format(Query, DateTime.Today.Date.ToString(), customer, Convert.ToInt32(GrdTotalTb.Text));
                                Con.SetData(Query);
                        }
                        catch (Exception ex)
                        {


                        }
                }


                int GrdTotal;
                int Amount;
                protected void AddToBillBtn_Click(object sender, EventArgs e)
                {
                        if (PNameTb.Value == "" || QtyTb.Value == "" || PriceTb.Value == "")
                        {

                        }
                        else
                        {
                                int total = Convert.ToInt32(QtyTb.Value) * Convert.ToInt32(PriceTb.Value);
                                DataTable dt = (DataTable)ViewState["Bill"];
                                dt.Rows.Add(
                                        ShoppingCartList.Rows.Count + 1,
                                        PNameTb.Value.Trim(),
                                        PriceTb.Value.Trim(),
                                        QtyTb.Value.Trim(),
                                        total);
                                ViewState["Bill"] = dt;
                                this.BindGrid();
                                UpdateStock();
                                GrdTotal = 0;
                                for (int i = 0; i < ShoppingCartList.Rows.Count; i++)
                                {
                                        GrdTotal = GrdTotal + Convert.ToInt32(ShoppingCartList.Rows[i].Cells[4].Text);
                                }
                                Amount = GrdTotal;
                                GrdTotalTb.Text = Convert.ToString(GrdTotal);
                                PNameTb.Value = "";
                                QtyTb.Value = "";
                                PriceTb.Value = "";
                        }

                }

                protected void PrintBtn_Click(object sender, EventArgs e)
                {
                        InsertBill();
                }
        }
}