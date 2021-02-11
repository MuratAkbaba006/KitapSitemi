<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YoneticiGiris.aspx.cs" Inherits="Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>   <link href="css/bootstrap.min.css" rel="stylesheet"/>
      <link href="font-awesome/css/font-awesome.css" rel="stylesheet"/>
      <link href="css/animate.css" rel="stylesheet"/>
      <link href="css/style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginColumns animated fadeInDown">
         <div class="row">
           
            <div class="col-md-6">
               <div class="inqbox-content">
                  
                    <div class="form-group form-focus">
                                <label class="control-label">Kullanıcı Adı</label>
                               
                            <asp:TextBox runat="server" ID ="k_ad" CssClass="form-control floating"></asp:TextBox>

                            </div>
                            <div class="form-group form-focus">
                            <label class="control-label">Şifre</label>
                            <asp:TextBox runat="server" ID ="pass" CssClass="form-control floating"   type="password"></asp:TextBox>

                            
                            </div>
                            <div class="form-group text-center">
            <asp:Button runat ="server" ID ="giris" Text="Giriş" CssClass ="btn btn-primary btn-block account-btn"  OnClick="giris_Click"/>
                 
               </div>
                    <div class="text-center">
                                <a href="Kayit.aspx">Kayıt Ol</a>
                            </div>
            </div>
         </div>
         <hr/>
         
      </div>
    </form>
</body>
</html>
