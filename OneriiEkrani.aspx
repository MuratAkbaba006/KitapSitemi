<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="OneriiEkrani.aspx.cs" Inherits="OneriiEkrani" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Ortak Okuma</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                              
                                <th>Kullanıcı</th>
                                <th>Okunma Sayisi</th>
                                
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="ortakokuma">
                                <ItemTemplate>

                                    <tr>
                                     <td><%#Eval("kullanici_adi") %>   <%#Eval("kullanici_soyadi") %></td>
                                        <td><%#Eval("ortak") %></td>
                                        
                             
 
  
                                    </tr>
                                </ItemTemplate>

                            </asp:Repeater>


                        </tbody>
                    </table>
                </div>
            </div>
        </div>
<div class="col-lg-6">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Ortak Puan</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                              
                                <th>Kullanıcı</th>
                                <th>Ortak Puan Sayisi</th>
                                
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="ortakpuan">
                                <ItemTemplate>

                                    <tr>
                                     <td><%#Eval("kullanici_adi") %>   <%#Eval("kullanici_soyadi") %></td>
                                        <td><%#Eval("ortak") %></td>
                                        
                             
 
  
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

