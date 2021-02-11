<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.master" AutoEventWireup="true" CodeFile="KitapGuncelleme.aspx.cs" Inherits="KitapGuncelleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="col-md-6">
                        <div class="card-box">

                          <asp:Label runat="server" ID="errorlabel" ForeColor="Red"></asp:Label>

                            <h4 class="card-title">KİTAP BİLGİLERİNİ GİRİNİZ</h4>
                          
                                <div class="form-group">
                                    <label>KİTAP ADI</label>
                                    <asp:TextBox runat="server" ID ="kitap_isim" CssClass="form-control"></asp:TextBox>
                                   
                                </div>
                                <div class="form-group">
                                    <label>RESİM</label>
                                   <asp:TextBox runat="server" ID ="kitap_resimyolu" CssClass="form-control"></asp:TextBox>
                                    <asp:FileUpload  runat="server" ID="resim"/>
                                    <asp:Button runat ="server" ID ="resimyukle" Text="Ekle" CssClass ="btn btn-primary"   OnClick="resimyukle_Click"/>

                                </div>
                                <div class="form-group">
                                    <label>KİTAP YAYIN EVİ</label>
                                    <asp:TextBox runat="server" ID ="kitap_yayinevi" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>KİTAP AÇIKLAMA</label>
                                   <asp:TextBox runat="server"  Rows="5"  TextMode="MultiLine"  ID ="kitap_aciklama"   CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>YAZAR</label>
                                    
                                    <asp:DropDownList runat="server" ID="yazar" CssClass="form-control"></asp:DropDownList>
                                </div>
                              
                                <div class="text-right">
                                    <asp:Button runat ="server" ID ="Kaydet" Text="KAYDET" CssClass ="btn btn-primary"  OnClick="Kaydet_Click" />
                                   
                                </div>
                            
                        </div>
                    </div>
</asp:Content>

