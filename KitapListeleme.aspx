<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="KitapListeleme.aspx.cs" Inherits="KitapListeleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="row">
        <div class="col-lg-12">
            <div class="card-box">
                <div class="card-block">
                    <h5 class="text-bold card-title">Bordered Table</h5>

                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Resim</th>
                                <th>Kitap Adı</th>
                                <th>Yayın Evi</th>
                                <th>Yazar</th>
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
                                        <td><%#Eval("yazar_adi") %>   <%#Eval("yazar_soyadi") %></td>
                                        <td>
                                            <asp:Button runat="server" ID="Sil" Text="Sil" CommandArgument='<%#Eval("kitap_id")%>' OnCommand="Sil_Command" CssClass="btn btn-primary" />
                                            <asp:Button runat="server" ID="Guncelle" CommandArgument='<%#Eval("kitap_id")%>' OnCommand="Guncelle_Command" Text="Güncelle" CssClass="btn btn-primary" />


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

