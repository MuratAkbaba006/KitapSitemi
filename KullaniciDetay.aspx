<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master"enableEventValidation="false" AutoEventWireup="true" CodeFile="KullaniciDetay.aspx.cs" Inherits="KullaniciDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="row">
        <div class="col-xs-12">
            <h4 class="page-title">Kitap Detay</h4>
        </div>
    </div>
    <div class="card-box">
        <div class="row">
            <div class="col-sm-6 col-xs-12">
                <div class="product-view">
                    <div class="proimage-wrap">
                        <div class="pro-image" id="pro_popup">
                            <a>


                                <asp:Image runat="server" ID="kullaniciresim" class="img-responsive" />

                            </a>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-xs-12">
                <div class="product-info">
                    <h2>

                        <asp:Label ID="adsoyad" runat="server"></asp:Label>

                    </h2>
                    <asp:Label ID="kullaniciad" runat="server"></asp:Label><br />
                  

                    <div>
                        <asp:Button runat="server" ID="okudum" OnClick="okudum_Click" CssClass="btn btn-primary btn-lg" Text="Mesaj" />


                    </div>
                    <hr />
                    

                    </div>
 
            </div>
            <div class="col-xs-12">
                <ul class="nav nav-tabs nav-tabs-bottom">
                    <li class="active"><a href="#product_desc" data-toggle="tab">Okunan Kitaplar</a></li>
                     <li><a href="#puan" data-toggle="tab">Puan Verilen Kitaplar</a></li>
                    <li><a href="#product_reviews" data-toggle="tab">İncelemeler</a></li>
                    <li><a href="#alintilar" data-toggle="tab">Alıntılar</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="product_desc">
                        <div class="product-content">
                            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Okunan Kitaplar</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Resim</th>
                                <th>Kitap Adı</th>
                                <th>Yayın Evi</th>
                                 <th>Okunma Sayisi</th>
                                <th>İşlemler</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="kitaplarim">
                                <ItemTemplate>

                                    <tr>
                                        <td>
                                            <img style="height: 100px; width: 100px" src="<%#Eval("kitap_resimyolu") %>" /></td>
                                        <td><%#Eval("kitap_isim") %></td>
                                        <td><%#Eval("kitap_yayinevi") %></td>
                                       


                                        <td><%#Eval("kitap_okumasayisi") %></td>
                                        <td>
                                             <asp:Button runat="server" ID="kitapdetay" Text="Kitap Detay" CommandArgument='<%#Eval("kitap_id")%>' OnCommand="kitapdetay_Command" CssClass="btn btn-primary" />


                                        </td>

                                    </tr>
                                </ItemTemplate>

                            </asp:Repeater>


                        </tbody>
                    </table>
                </div>
            </div>
                         </div>
                    </div>

                     <div class="tab-pane" id="puan">
                        <div class="product-content">
                            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Puan Verilen Kitaplar</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Resim</th>
                                <th>Kitap Adı</th>
                                <th>Yayın Evi</th>
                                 <th>Okunma Sayisi</th>
                                <th>İşlemler</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="puanlar">
                                <ItemTemplate>

                                    <tr>
                                        <td>
                                            <img style="height: 100px; width: 100px" src="<%#Eval("kitap_resimyolu") %>" /></td>
                                        <td><%#Eval("kitap_isim") %></td>
                                        <td><%#Eval("kitap_yayinevi") %></td>
                                       


                                        <td><%#Eval("kitap_okumasayisi") %></td>
                                        <td>
                                            <asp:Button runat="server" ID="kitapdetay" Text="Kitap Detay" CommandArgument='<%#Eval("kitap_id")%>' CssClass="btn btn-primary" />


                                        </td>

                                    </tr>
                                </ItemTemplate>

                            </asp:Repeater>


                        </tbody>
                    </table>
                </div>
            </div>
                         </div>
                    </div>
                    <div class="tab-pane" id="product_reviews">
                        <div class="product-reviews">
                            <h3>İncelemeler</h3>
                            <ul class="review-list">
                                <asp:Repeater ID="incelemeler" runat="server">
                                    <ItemTemplate>

                                        <li>
                                            <div class="review">
                                                <div class="review-author">
                                                    <img class="avatar" alt="" src='<%#Eval("kitap_resimyolu") %>'>
                                                </div>
                                                <div class="review-block">
                                                    <div class="review-by">
                                                        <span class="review-author-name"><%#Eval("kitap_isim") %> </span>

                                                    </div>
                                                    <p><%#Eval("inceleme_inceleme") %></p>
                                                </div>
                                            </div>
                                        </li>

                                    </ItemTemplate>

                                </asp:Repeater>


                            </ul>

                        </div>
                         
                    </div>
                    <div class="tab-pane" id="alintilar">
                        <div class="product-reviews">
                            <h3>Alıntılar</h3>
                            <ul class="review-list">
                               <asp:Repeater ID="alintilarim" runat="server">
                                    <ItemTemplate>

                                        <li>
                                            <div class="review">
                                                <div class="review-author">
                                                    <img class="avatar" alt="" src='<%#Eval("kitap_resimyolu") %>'>
                                                </div>
                                                <div class="review-block">
                                                    <div class="review-by">
                                                        <span class="review-author-name"><%#Eval("kitap_isim") %> </span>

                                                    </div>
                                                    <p><%#Eval("alinti_cumle") %> Sayfa(<%#Eval("alinti_sayfa") %>)</p>
                                                </div>
                                            </div>
                                        </li>

                                    </ItemTemplate>

                                </asp:Repeater>
                            </ul>
                            
                        </div>
                         
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

