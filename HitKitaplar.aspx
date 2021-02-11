<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="HitKitaplar.aspx.cs" Inherits="HitKitaplar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Populer Kitaplar</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Resim</th>
                                <th>Kitap Adı</th>
                                <th>Yayın Evi</th>
                                 <th>Okunma Sayisi</th>
                                 <th>Ort. Puan</th>
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
                                             <td><%#Eval("ortalama") %></td>
                                    </tr>
                                </ItemTemplate>

                            </asp:Repeater>


                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

