<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.master" AutoEventWireup="true" CodeFile="YazarEkleme.aspx.cs" Inherits="YazarEkleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   <div class="col-md-6">
                        <div class="card-box">
                            <asp:Label runat="server" ID="errorlabel" ForeColor="Red"></asp:Label>
                            <h4 class="card-title">YAZAR BİLGİLERİNİ GİRİNİZ</h4>
                          
                                <div class="form-group">
                                    <label>AD</label>
                                    <asp:TextBox runat="server" required="required" ID ="yazar_ad" CssClass="form-control"></asp:TextBox>
                                   
                                </div>
                                <div class="form-group">
                                    <label>SOYAD</label>
                                   <asp:TextBox runat="server" required="required" ID ="yazar_soyad" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>DOĞUM YERİ</label>
                                    <asp:TextBox runat="server" required="required" ID ="yazar_dyeri" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>DOĞUM TARİHİ</label>
                                   <asp:TextBox runat="server" required="required"  ID ="yazar_dtarih" type ="date" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>ÖLÜM TARİHİ</label>
                                   <asp:TextBox runat="server" ID ="yazar_otarih" type ="date" CssClass="form-control"></asp:TextBox>

                                </div>
                              
                                <div class="text-right">
                                    <asp:Button runat ="server" ID ="Kaydet" Text="KAYDET" CssClass ="btn btn-primary" OnClick="Kaydet_Click"/>
                                   
                                </div>
                            
                        </div>
                    </div>

</asp:Content>

