<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kayit.aspx.cs" Inherits="Kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="css/bootstrap.min.css" rel="stylesheet"/>
      <link href="fonts/font-awesome/css/font-awesome.css" rel="stylesheet"/>
      <link href="css/animate.css" rel="stylesheet"/>
      <link href="css/style.css" rel="stylesheet"/>
      <link href="css/forms/kforms.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <form runat="server" >  <div class="main-wrapper">
        <div class="account-page">
            <div class="container">
                <h3 class="account-title">Kayıt</h3>
               <div class="col-md-12">
                        <div class="card-box">

                          <asp:Label runat="server" ID="errorlabel" ForeColor="Red"></asp:Label>

                            <h4 class="card-title">LÜTFEN BİLGİLERİNİZİ GİRİNİZ</h4>
                          
                                <div class="form-group">
                                    <label>Adınız</label>
                                    <asp:TextBox runat="server" ID ="ad" CssClass="form-control"></asp:TextBox>
                                   
                                </div>
                                 <div class="form-group">
                                    <label>Soyadınız</label>
                                    <asp:TextBox runat="server" ID ="soyad" CssClass="form-control"></asp:TextBox>
                                   
                                </div>
                                <div class="form-group">
                                    <label>RESİM</label>
                                   <asp:TextBox runat="server" ID ="kitap_resimyolu" CssClass="form-control"></asp:TextBox>
                                    <asp:FileUpload  runat="server" ID="resim"/>
                                    <asp:Button runat ="server" ID ="resimyukle" Text="Ekle" CssClass ="btn btn-primary"  OnClick="resimyukle_Click"/>

                                </div>
                                <div class="form-group">
                                    <label>Doğum Tarihi</label>
                                    <asp:TextBox runat="server" ID ="dtarihi" type="date" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>Kullanıcı Ad</label>
                                   <asp:TextBox runat="server"     ID ="kullanici_ad"   CssClass="form-control"></asp:TextBox>
                                </div>
                                  <div class="form-group">
                                    <label>Parola</label>
                                   <asp:TextBox runat="server"     ID ="parola"   CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>Cinsiyet</label>
                                    
                                    <asp:DropDownList runat="server" ID="cinsiyet" CssClass="form-control">
                                        <asp:ListItem Value="1">Erkek</asp:ListItem>
                                        <asp:ListItem  Value="0">Kız</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                              
                                <div class="text-right">
                                    <asp:Button runat ="server" ID ="Kaydet" Text="KAYDET" CssClass ="btn btn-primary"   OnClick="Kaydet_Click"/>
                                   
                                </div>
                            
                        </div>
                    </div>
            </div>
        </div>
    </div></form>
  
    <div class="sidebar-overlay" data-reff=""></div>
      <script src="js/jquery-2.1.1.js"></script>
      <script src="js/bootstrap.min.js"></script>
      <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
      <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>
      <!-- Custom and plugin javascript -->
      <script src="js/main.js"></script>
      <script src="js/plugins/pace/pace.min.js"></script>
</body>
</html>
