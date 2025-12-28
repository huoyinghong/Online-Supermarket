using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Supermarket.Views
{
        public partial class Login : System.Web.UI.Page
        {
                Models.Functions Con;

                protected void Page_Load(object sender, EventArgs e)
                {
                        Con = new Models.Functions();

                }
                public static string UName = "";
                public static int User;

                protected void LoginBtn_Click(object sender, EventArgs e)
                {
                        if (UsernameTb.Value == ""||PasswordTb.Value == "")
                        {
                                ErrMsg.Text = "Please enter username and password";
                        }
                        else if(UsernameTb.Value == "Admin@admin.com" || PasswordTb.Value == "password")
                        {
                                Response.Redirect("Admin/Products.aspx");
                        }
                        else
                        {
                                string Query = "select * from CustomerTb1 where CustEmail = '{0}' and CustPassword = '{1}'";
                                Query = string.Format(Query, UsernameTb.Value, PasswordTb.Value);
                                DataTable dt = Con.GetData(Query);
                                if (dt.Rows.Count == 0)
                                {
                                        ErrMsg.Text = "Invalid username or password";
                                }
                                else
                                {
                                        UName = UsernameTb.Value;
                                        User = Convert.ToInt32(dt.Rows[0][0].ToString());
                                        Response.Redirect("Customer/Billing.aspx");
                                }
                        }
                }
        }
}