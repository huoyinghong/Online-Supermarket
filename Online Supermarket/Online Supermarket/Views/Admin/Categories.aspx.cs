using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views.Admin
{
        public partial class Categories : System.Web.UI.Page
        {
                Models.Functions Con;

                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();
                        ShowCategories();
                }

                private void ShowCategories()
                {
                        string Query = "Select * from CategoryTb1";
                        CategoryList.DataSource = Con.GetData(Query);
                        CategoryList.DataBind();
                        CategoryList.HeaderRow.Cells[1].Text = "Category ID";
                        CategoryList.HeaderRow.Cells[2].Text = "Category Name";
                        CategoryList.HeaderRow.Cells[3].Text = "Category Description";
                }

                protected void SaveBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (CateNameTb.Value == "" || DescriptionTb.Value == "" )
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string CateName = CateNameTb.Value;
                                        string CateDes = DescriptionTb.Value;

                                        string Query = "insert into CategoryTb1 values('{0}','{1}')";
                                        Query = string.Format(Query, CateName, CateDes);
                                        Con.SetData(Query);
                                        ShowCategories();
                                        ErrMsg.Text = "Category infomations has been added";
                                        CateNameTb.Value = "";
                                        DescriptionTb.Value = "";
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }

                int key = 0;
                protected void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        CateNameTb.Value = CategoryList.SelectedRow.Cells[2].Text;
                        DescriptionTb.Value = CategoryList.SelectedRow.Cells[3].Text;
                        if (CateNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(CategoryList.SelectedRow.Cells[1].Text);
                        }
                }

                protected void EditBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (CateNameTb.Value == "" || DescriptionTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string CateName = CateNameTb.Value;
                                        string CateDes = DescriptionTb.Value;

                                        string Query = "update CategoryTb1 set CateName = '{0}',CateDescription = '{1}' where CateId = {2}";
                                        Query = string.Format(Query, CateName, CateDes, CategoryList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowCategories();
                                        ErrMsg.Text = "Category infomations has been updated";
                                        CateNameTb.Value = "";
                                        DescriptionTb.Value = "";
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
                                if (CateNameTb.Value == "" || DescriptionTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        //string CateName = CateNameTb.Value;
                                        //string CateDes = DescriptionTb.Value;

                                        string Query = "delete from CategoryTb1 where CateId = {0}";
                                        Query = string.Format(Query,  CategoryList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowCategories();
                                        ErrMsg.Text = "Category infomations has been deleted";
                                        CateNameTb.Value = "";
                                        DescriptionTb.Value = "";
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }
        }
}