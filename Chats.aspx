<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" EnableEventValidation="false"  CodeFile="Chats.aspx.cs" Inherits="Chats" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="mail-box">
                        <table class="table table-hover table-mail">
                            <thead>
                                <tr>
                                    <th>Gönderen</th>
                                     <th>Başlık</th>
                                     <th>Tarih</th>
                                </tr>

                            </thead>
                           <tbody>
                                <asp:Repeater runat="server" ID="mesajlar">
                                <ItemTemplate>
                              <tr class="unread">
                          
                                 <td class="mail-ontact"><a ><%#Eval("kullanici_adi") %>   <%#Eval("kullanici_soyadi") %> </a></td>
                                 <td class="mail-subject"><a ><%#Eval("mesaj_baslik") %></a></td>
                                 
                                 <td class=" mail-date"><%#Eval("mesaj_tarih") %></td>
                                  <td><asp:Button runat="server" ID="detay" Text="Görüntüle" CssClass="btn btn-sm" CommandArgument='<%#Eval("mesaj_id")%>' OnCommand="detay_Command" /></td>
                              </tr>


                                </ItemTemplate>


                                </asp:Repeater>
                             
                           </tbody>
                        </table>
                     </div>
</asp:Content>

