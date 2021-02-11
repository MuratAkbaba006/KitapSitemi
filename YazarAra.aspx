﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="YazarAra.aspx.cs" Inherits="YazarAra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div class="row filter-row">
                  
                    <div class="col-sm-3 col-xs-6">
                        <div class="form-group form-focus">
                            <label class="control-label">Yazar Adı</label>
                            <asp:TextBox runat="server"  ID="aranan" CssClass="form-control floating"></asp:TextBox>
                         </div>
                    </div>
                    
                    <div class="col-sm-3 col-xs-6">

                        <asp:Button runat="server" Text="Ara" ID="ara" OnClick="ara_Click" CssClass="btn btn-success btn-block" />
                   
                    </div>
                </div>
    
    <div class="row">
        <div class="col-lg-12">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Arama Sonuçları</h5>

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
                                            <asp:Button runat="server" ID="kitaplistele" Text="Kitaplar" CommandArgument='<%#Eval("yazar_id")%>'   OnCommand="kitaplistele_Command" CssClass="btn btn-primary" />
 

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

