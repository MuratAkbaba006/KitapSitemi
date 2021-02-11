<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="col-lg-9 animated fadeInRight">
         
        <div class="mail-box">
            <div class="mail-body">

                <div class="form-group">
                    <label class="col-sm-2 control-label">Alıcı:</label>
                    <div class="col-sm-10">
                        <asp:TextBox runat="server" ID="alici" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">Mesaj:</label>
                        <div class="col-sm-10">
                            <asp:TextBox runat="server" ID="konu" CssClass="form-control"></asp:TextBox></div>
                    </div>

                </div>
                <br />
                <div class="mail-text h-200">
                    <asp:TextBox runat="server" ID="mesaj" TextMode="MultiLine" Rows="5" Columns="100" CssClass="form-control"> </asp:TextBox>

                    <div class="clearfix"></div>
                </div>
                <div class="mail-body text-right tooltip-demo">
                    <asp:Button runat="server" ID="gonder" Text="Gönder" CssClass="btn btn-sm btn-primary" OnClick="gonder_Click" />
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
</asp:Content>

