using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views.Admin
{
        public partial class Products : System.Web.UI.Page
        {
                Models.Functions Con;
                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();
                        if (!IsPostBack)
                        {
                                ShowProducts();
                                GetCategories();
                                GetManufactors();
                        }
                }

                private void ShowProducts()
                {
                        string Query = "Select * from ProductTb1";
                        ProductList.DataSource = Con.GetData(Query);
                        ProductList.DataBind();
                        ProductList.HeaderRow.Cells[1].Text = "Product ID";
                        ProductList.HeaderRow.Cells[2].Text = "Product Name";
                        ProductList.HeaderRow.Cells[3].Text = "Manufacturer Name";
                        ProductList.HeaderRow.Cells[4].Text = "Category";
                        ProductList.HeaderRow.Cells[5].Text = "Price";
                        ProductList.HeaderRow.Cells[6].Text = "Quantity";
                }

                private void GetCategories()
                {
                        string Query = "select * from CategoryTb1";
                        DataTable dt = Con.GetData(Query);

                        PCateCb.DataSource = dt;
                        PCateCb.DataTextField = "CateName";
                        PCateCb.DataValueField = "CateId";
                        PCateCb.DataBind();
                }


                private void GetManufactors()
                {
                        string Query = "select * from ManufactorTb1";
                        DataTable dt = Con.GetData(Query);

                        PManufactCb.DataSource = dt;
                        PManufactCb.DataTextField = "ManufactName";
                        PManufactCb.DataValueField = "ManufactId";
                        PManufactCb.DataBind();
                }


                protected void SaveBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCateCb.SelectedIndex == -1 || PPriceTb.Value == "" || PQtyTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string PName = PNameTb.Value;
                                        int PManufact = int.Parse(PManufactCb.SelectedValue);
                                        int PCate = int.Parse(PCateCb.SelectedValue);

                                        int PPrice = Convert.ToInt32(PPriceTb.Value);
                                        int PQty = Convert.ToInt32(PQtyTb.Value);


                                        string Query = "insert into ProductTb1 values('{0}','{1}','{2}','{3}','{4}')";
                                        Query = string.Format(Query, PName, PManufact, PCate, PPrice, PQty);
                                        Con.SetData(Query);
                                        ShowProducts();
                                        ErrMsg.Text = "Product infomations has been added";
                                        PNameTb.Value = "";
                                        PManufactCb.SelectedIndex = -1;
                                        PCateCb.SelectedIndex = -1;
                                        PQtyTb.Value = "";
                                        PPriceTb.Value = "";

                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }

                int key = 0;
                protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        PNameTb.Value = ProductList.SelectedRow.Cells[2].Text;
                        PManufactCb.SelectedValue = ProductList.SelectedRow.Cells[3].Text;
                        PCateCb.SelectedValue = ProductList.SelectedRow.Cells[4].Text;
                        PQtyTb.Value = ProductList.SelectedRow.Cells[5].Text;
                        PPriceTb.Value = ProductList.SelectedRow.Cells[6].Text;

                        if (PNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
                        }
                }

                protected void EditBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCateCb.SelectedIndex == -1 || PPriceTb.Value == "" || PQtyTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string PName = PNameTb.Value;
                                        int PManufact = int.Parse(PManufactCb.SelectedValue);
                                        int PCate = int.Parse(PCateCb.SelectedValue);

                                        int PPrice = Convert.ToInt32(PPriceTb.Value);
                                        int PQty = Convert.ToInt32(PQtyTb.Value);


                                        string Query = "update ProductTb1 set PName='{0}', PManufact='{1}',PCategory='{2}',PQty='{3}',PPrice='{4}' where Pid={5}";
                                        Query = string.Format(Query, PName, PManufact, PCate, PPrice, PQty, ProductList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowProducts();
                                        ErrMsg.Text = "Product infomations has been updated";
                                        PNameTb.Value = "";
                                        PManufactCb.SelectedIndex = -1;
                                        PCateCb.SelectedIndex = -1;
                                        PQtyTb.Value = "";
                                        PPriceTb.Value = "";

                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }

                protected void DeleteBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCateCb.SelectedIndex == -1 || PPriceTb.Value == "" || PQtyTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        //string PName = PNameTb.Value;
                                        //int PManufact = int.Parse(PManufactCb.SelectedValue);
                                        //int PCate = int.Parse(PCateCb.SelectedValue);

                                        //int PPrice = Convert.ToInt32(PPriceTb.Value);
                                        //int PQty = Convert.ToInt32(PQtyTb.Value);


                                        string Query = "delete ProductTb1 where Pid={0}";
                                        Query = string.Format(Query, ProductList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowProducts();
                                        ErrMsg.Text = "Product infomations has been deleted";
                                        PNameTb.Value = "";
                                        PManufactCb.SelectedIndex = -1;
                                        PCateCb.SelectedIndex = -1;
                                        PQtyTb.Value = "";
                                        PPriceTb.Value = "";

                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }
        }
}