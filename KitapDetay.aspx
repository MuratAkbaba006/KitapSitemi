<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="KitapDetay.aspx.cs" Inherits="KitapDetay" %>

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


                                <asp:Image runat="server" ID="kitapresim" class="img-responsive" />

                            </a>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-xs-12">
                <div class="product-info">
                    <h2>

                        <asp:Label ID="kitapad" runat="server"></asp:Label>

                    </h2>
                    <asp:Label ID="yazarad" runat="server"></asp:Label><br />
                    <asp:Label ID="yayınevi" runat="server"></asp:Label>

                    <div class="rating">
                        <p>
                            <span>Ortalama Puan:
                                <asp:Label ID="ortalamapuan" runat="server"></asp:Label></span>
                            <span>/ Okunma Sayısı:
                                <asp:Label ID="okumasayisi" runat="server"></asp:Label></span>
                        </p>
                    </div>

                    <div>
                        <asp:Button runat="server" ID="okudum" OnClick="okudum_Click" CssClass="btn btn-primary btn-lg" Text="Okudum" />


                    </div>
                    <hr />
                    <div class="row">
                        <div class="col-md-6">
                              <asp:DropDownList runat="server" CssClass="form-control" ID="puan">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>

                        </asp:DropDownList>
                        </div>
                      <div class="col-md-6">
                               <asp:Button runat="server" ID="puanver"  OnClick="puanver_Click" CssClass="btn btn-primary btn-lg" Text="Puan Ver" />

                      </div>

                    </div>
                </div>
            </div>
            <div class="col-xs-12">
                <ul class="nav nav-tabs nav-tabs-bottom">
                    <li class="active"><a href="#product_desc" data-toggle="tab">Açıklama</a></li>
                    <li><a href="#product_reviews" data-toggle="tab">İncelemeler</a></li>
                    <li><a href="#alintilar" data-toggle="tab">Alıntılar</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="product_desc">
                        <div class="product-content">
                            <p>
                                <asp:Label runat="server" ID="aciklama"></asp:Label></p>
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
                                                <div class="text-center">
                                                    <img class="img-circle m-t-xs img-responsive" style="width:100px;height:100px" alt="" src='<%#Eval("kullanici_resimyolu") %>'>
                                                </div>
                                                <div class="review-block">
                                                    <div class="review-by">
                                                        <span class="review-author-name"><%#Eval("kullanici_adi") %>  <%#Eval("kullanici_soyadi") %></span>

                                                    </div>
                                                    <p><%#Eval("inceleme_inceleme") %></p>
                                                </div>
                                            </div>
                                        </li>

                                    </ItemTemplate>

                                </asp:Repeater>


                            </ul>

                        </div>
                        <div class="product-write-review">
                            <h3>İnceleme Giriniz</h3>
                            <div class="row">
                                <div class="col-sm-8">
                                    <div class="form-group">
                                        <label>Yorum <span class="text-red">*</span></label>
                                         <asp:TextBox runat="server" ID="yorum" class="form-control"> </asp:TextBox>
                                    </div>



                                    <div class="review-submit">
                                        <asp:Button runat="server" Text="Ekle" ID="yorumgir"  OnClick="yorumgir_Click"  CssClass="btn" />

                                        
                                    </div>
                                </div>
                            </div>
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
                                                <div class="text-center">
                                                    <img class="img-circle m-t-xs img-responsive" style="width:100px;height:100px" alt="" src='<%#Eval("kullanici_resimyolu") %>'>
                                                </div>
                                                <div class="review-block">
                                                    <div class="review-by">
                                                        <span class="review-author-name"><%#Eval("kullanici_adi") %>  <%#Eval("kullanici_soyadi") %></span>

                                                    </div>
                                                    <p><%#Eval("alinti_cumle") %> Sayfa(<%#Eval("alinti_sayfa") %>)</p>
                                                </div>
                                            </div>
                                        </li>

                                    </ItemTemplate>

                                </asp:Repeater>
                            </ul>
                            
                        </div>
                        <div class="product-write-review">
                            <h3>Alıntı</h3>
                           
                                 <div class="row">
                                <div class="col-sm-8">
                                    <div class="form-group">
                                        <label>Alıntı <span class="text-red">*</span></label>
                                         <asp:TextBox runat="server" ID="alinti" class="form-control"> </asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <label>Sayfa <span class="text-red">*</span></label>
                                         <asp:TextBox runat="server" ID="sayfa"  class="form-control"> </asp:TextBox>
                                    </div>

                                    <div class="review-submit">
                                        <asp:Button runat="server" Text="Ekle" ID="alintigir"   OnClick="alintigir_Click"  CssClass="btn" />

                                        
                                    </div>
                                </div>
                            </div>
                         
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

