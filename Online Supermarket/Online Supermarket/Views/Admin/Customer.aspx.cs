using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views.Admin
{
        public partial class Customer : System.Web.UI.Page
        {
                Models.Functions Con;

                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();
                        ShowCustomers();
                }

                private void ShowCustomers()
                {
                        string Query = "Select * from CustomerTb1";
                        CustomerList.DataSource = Con.GetData(Query);
                        CustomerList.DataBind();
                        CustomerList.HeaderRow.Cells[1].Text = "Customer ID";
                        CustomerList.HeaderRow.Cells[2].Text = "Customer Name";
                        CustomerList.HeaderRow.Cells[3].Text = "Customer Email";
                        CustomerList.HeaderRow.Cells[4].Text = "Customer Phone";
                        CustomerList.HeaderRow.Cells[5].Text = "Customer Password";
                }

                protected void SaveBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (CusNameTb.Value == "" || CusEmailTb.Value == "" || CusPhoneTb.Value == "" || CusPasswordTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string CusName = CusNameTb.Value;
                                        string CusEmail = CusEmailTb.Value;
                                        string CusPhone = CusPhoneTb.Value;
                                        string CusPassword = CusPasswordTb.Value;


                                        string Query = "insert into CustomerTb1 values('{0}','{1}','{2}','{3}')";
                                        Query = string.Format(Query, CusName, CusEmail, CusPhone, CusPassword);
                                        Con.SetData(Query);
                                        ShowCustomers();
                                        ErrMsg.Text = "Customer infomations has been added";
                                        CusNameTb.Value = "";
                                        CusEmailTb.Value = "";
                                        CusPhoneTb.Value = "";
                                        CusPasswordTb.Value = "";
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }

                int key = 0;
                protected void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
                {
                        CusNameTb.Value = CustomerList.SelectedRow.Cells[2].Text;
                        CusEmailTb.Value = CustomerList.SelectedRow.Cells[3].Text;
                        CusPhoneTb.Value = CustomerList.SelectedRow.Cells[4].Text;
                        CusPasswordTb.Value = CustomerList.SelectedRow.Cells[5].Text;


                        if (CusNameTb.Value == "")
                        {
                                key = 0;
                        }
                        else
                        {
                                key = Convert.ToInt32(CustomerList.SelectedRow.Cells[1].Text);
                        }
                }

                protected void EditBtn_Click(object sender, EventArgs e)
                {
                        try
                        {
                                if (CusNameTb.Value == "" || CusEmailTb.Value == "" || CusPhoneTb.Value == "" || CusPasswordTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        string CusName = CusNameTb.Value;
                                        string CusEmail = CusEmailTb.Value;
                                        string CusPhone = CusPhoneTb.Value;
                                        string CusPassword = CusPasswordTb.Value;


                                        string Query = "update CustomerTb1 set CustName = '{0}', CustEmail = '{1}', CustPhone = '{2}', CustPassword = '{3}' where CustId = {4}";
                                        Query = string.Format(Query, CusName, CusEmail, CusPhone, CusPassword, CustomerList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowCustomers();
                                        ErrMsg.Text = "Customer infomations has been updated";
                                        CusNameTb.Value = "";
                                        CusEmailTb.Value = "";
                                        CusPhoneTb.Value = "";
                                        CusPasswordTb.Value = "";
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
                                if (CusNameTb.Value == "" || CusEmailTb.Value == "" || CusPhoneTb.Value == "" || CusPasswordTb.Value == "")
                                {
                                        ErrMsg.Text = "Missing information!";
                                }
                                else
                                {
                                        //string CusName = CusNameTb.Value;
                                        //string CusEmail = CusEmailTb.Value;
                                        //string CusPhone = CusPhoneTb.Value;
                                        //string CusPassword = CusPasswordTb.Value;


                                        string Query = "delete from CustomerTb1 where CustId = {0}";
                                        Query = string.Format(Query, CustomerList.SelectedRow.Cells[1].Text);
                                        Con.SetData(Query);
                                        ShowCustomers();
                                        ErrMsg.Text = "Customer infomations has been deleted";
                                        CusNameTb.Value = "";
                                        CusEmailTb.Value = "";
                                        CusPhoneTb.Value = "";
                                        CusPasswordTb.Value = "";
                                }
                        }
                        catch (Exception ex)
                        {
                                ErrMsg.Text = ex.Message;
                        }
                }
        }
}