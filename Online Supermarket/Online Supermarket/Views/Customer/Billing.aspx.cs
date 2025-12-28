using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views.Customer
{
        public partial class Billing : System.Web.UI.Page
        {
                Models.Functions Con;
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
                        ProductList.HeaderRow.Cells[3].Text = "Price";
                        ProductList.HeaderRow.Cells[4].Text = "Quantity";
                }

                int key = 0;
                int stock = 0;
                protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        PNameTb.Value = ProductList.SelectedRow.Cells[2].Text;
                        PriceTb.Value = ProductList.SelectedRow.Cells[3].Text;
                        stock = Convert.ToInt32(ProductList.SelectedRow.Cells[4].Text);

                        if (PNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
                        }
                }

                protected void AddToBillBtn_Click(object sender, EventArgs e)
                {

                }
        }
}