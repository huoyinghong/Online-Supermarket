using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views.Admin
{
        public partial class Suppliers : System.Web.UI.Page
        {
                Models.Functions Con;
                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();
                        ShowManufactors();
                }

                private void ShowManufactors()
                {
                        string Query = "Select * from ManufactorTb1";
                        ManufactList.DataSource = Con.GetData(Query);
                        ManufactList.DataBind();
                        ManufactList.HeaderRow.Cells[1].Text = "ID";
                        ManufactList.HeaderRow.Cells[2].Text = "Manufactor Name";
                        ManufactList.HeaderRow.Cells[3].Text = "Production License Number";
                        ManufactList.HeaderRow.Cells[4].Text = "Place of Origin";
                }
                protected void SaveBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (MNameTb.Value == "" || ProdNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string MName = MNameTb.Value;
                                        string ProdNum = ProdNumTb.Value;
                                        string Place = PlaceCb.SelectedItem.ToString();

                                        string Query = "insert into ManufactorTb1 values('{0}','{1}','{2}')";
                                        Query = string.Format(Query, MName, ProdNum, Place);
                                        Con.SetData(Query);
                                        ShowManufactors();
                                        ErrMsg.Text = "Manufactor infomations has been added";
                                        MNameTb.Value = "";
                                        ProdNumTb.Value = "";
                                        PlaceCb.SelectedIndex = -1;
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }

                int key = 0;
                protected void ManufactList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        MNameTb.Value = ManufactList.SelectedRow.Cells[2].Text;
                        ProdNumTb.Value = ManufactList.SelectedRow.Cells[3].Text;
                        PlaceCb.SelectedValue = ManufactList.SelectedRow.Cells[4].Text;
                        if (MNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(ManufactList.SelectedRow.Cells[1].Text);
                        }
                }

                protected void EditBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (MNameTb.Value == "" || ProdNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string MName = MNameTb.Value;
                                        string ProdNum = ProdNumTb.Value;
                                        string Place = PlaceCb.SelectedItem.ToString();

                                        string Query = "update ManufactorTb1 set ManufactName = '{0}', ManufactPLN = '{1}', ManufactPlace = '{2}' where ManufactId = {3}";
                                        Query = string.Format(Query, MName, ProdNum, Place, ManufactList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowManufactors();
                                        ErrMsg.Text = "Manufactor infomations has been updated";
                                        MNameTb.Value = "";
                                        ProdNumTb.Value = "";
                                        PlaceCb.SelectedIndex = -1;
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
                                if (MNameTb.Value == "" || ProdNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                                {
                                        ErrMsg.Text = "Please select one manufactor!";
                                }
                                else
                                {
                                        string MName = MNameTb.Value;
                                        string ProdNum = ProdNumTb.Value;
                                        string Place = PlaceCb.SelectedItem.ToString();

                                        string Query = "delete from ManufactorTb1 where ManufactId = {0}";
                                        Query = string.Format(Query, ManufactList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowManufactors();
                                        ErrMsg.Text = "Manufactor infomations has been deleted";
                                        MNameTb.Value = "";
                                        ProdNumTb.Value = "";
                                        PlaceCb.SelectedIndex = -1;
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }
        }
}