<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="ChatDetail.aspx.cs" Inherits="ChatDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="col-lg-9 animated fadeInRight">
        <div class="mail-box-header">
            <div class="pull-right tooltip-demo">
                <asp:Button  ID="cevapla" runat="server" OnClick="cevapla_Click" Text="Cevapla"/>
            </div>
            <h2>Mesaj 
            </h2>
            <div class="mail-tools tooltip-demo m-t-md">
                <h3>
                    <span class="font-noraml">Konu: </span> <asp:Label runat="server" ID="konu"></asp:Label>
                </h3>
                <h5>
                    <span class="pull-right font-noraml">
                        <asp:Label runat="server" ID="tarih"></asp:Label></span>
                    <span class="font-noraml">Gönderen: </span>
                    <asp:Label runat="server" ID="gonderen"></asp:Label>
                </h5>
            </div>
        </div>
        <div class="mail-box">
            <div class="mail-body">
                <p>
                    <asp:Label runat="server" ID="mesaj"></asp:Label>
                </p>

            </div>


            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>

