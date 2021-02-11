<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" enableEventValidation="false" AutoEventWireup="true" CodeFile="HitYazarlar.aspx.cs" Inherits="HitYazarlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-lg-12">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Populer Yazarlar</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                              
                                <th>Yazar</th>
                                <th>Okunma Sayisi</th>
                                  <th>İşlemler</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="kitaplarim">
                                <ItemTemplate>

                                    <tr>
                                     <td><%#Eval("yazar_adi") %>   <%#Eval("yazar_soyadi") %></td>
                                        <td><%#Eval("yazar_osayisi") %></td>
                                         <td>
                                            <asp:Button runat="server" ID="kitaplistele" Text="Kitaplar" CommandArgument='<%#Eval("yazar_id")%>'  OnCommand="kitaplistele_Command" CssClass="btn btn-primary" />
 

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
</asp:Content>

