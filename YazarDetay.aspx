<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="YazarDetay.aspx.cs" Inherits="YazarDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="card-box m-b-0">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="profile-view">
                                 
                                <div class="profile-basic">
                                    <div class="row">
                                        <div class="col-md-5">
                                            <div class="profile-info-left">
                                                <asp:Label class="user-name m-t-0" runat="server" id="yazarad"></asp:Label>
                                                
                                            </div>
                                        </div>
                                        <div class="col-md-7">
                                            <ul class="personal-info">
                                                <li>
                                                    <span class="title">Doğum Yeri:</span>
                                                    <asp:Label class="text" runat="server" id="dogumyeri"></asp:Label>
                                                </li>
                                                <li>
                                                    <span class="title">Doğum Tarihi:</span>
                                                    <asp:Label class="text" runat="server" id="dogumtarihi"></asp:Label>
                                                </li>
                                                <li>
                                                    <span class="title">Ölüm Tarihi:</span>
                                                    <asp:Label class="text" runat="server" id="olumtarihi"></asp:Label>
                                                </li>
                                               
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
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
                                <th>Yazar</th>
                                <th>Okunma Sayisi</th>
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
                                        <td><%#Eval("yazar_adi") %>   <%#Eval("yazar_soyadi") %></td>
                             
 
                                             <td><%#Eval("kitap_okumasayisi") %></td>
 
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

