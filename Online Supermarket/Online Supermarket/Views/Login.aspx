<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online_Supermarket.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet"  href="../Assets/Lib/css/bootstrap.min.css"/>
</head>
<body>
    <div class ="container-fluid">
        <div class ="row mt-5 mb-5">

        </div>
        <div class ="row">
            <div class="col-md-4">   

            </div>
            <div class="col-md-4">   
                  <form id="form1" runat="server">
                      <div>
                          <divc class="row">
                              <div class="col-md-3"></div>
                                <div class="col-md-9">
                                  <img src="../Assets/Image/supermarkets.png" />
                              </div>
                          </divc>
                          
                      </div>
                        <div class="mt-3">
                            <label for="" class ="form-lable">Account</label>
                            <input type="text" placeholder ="Account" autocomplete="off" class ="form-control"/>
                        </div>
                      <div class="mt-3">
                            <label for="" class ="form-lable">Password</label>
                            <input type="password" placeholder ="Password" autocomplete="off" class ="form-control"/>
                        </div>
                      <div class="mt-3 d-grid">
                            <asp:Button Text="Log in" runat="server" Class="btn-success btn" />
                        </div>
                   </form>
            </div>
            <div class="col-md-4">   

            </div>
           
        </div>
    </div>
   
</body>
</html>
