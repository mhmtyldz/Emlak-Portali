<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Profilim.aspx.cs" Inherits="Profilim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="profil_butonlar">
        <ul>
            <li>
                <asp:LinkButton ID="lbKulBilgi" runat="server">Kullanıcı Bilgilerim</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbMesajlarim" runat="server">Mesajlarım</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbilanlarim" runat="server">İlanlarım</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbTakipEttiklerim" runat="server">Takip Ettiklerim</asp:LinkButton></li>
        </ul>
    </div>

    <div id="Kul_bilgi">
        <div id="profil_resim">
            <img src='KullaniciResimleri/<asp:Literal ID="ltrlResim"  runat="server"></asp:Literal>' />
            
        </div>
        <div id="profil_adsoyad">
            <asp:Label ID="lblAdSoyad" runat="server"></asp:Label>
            
        </div>
        <div id="profil_il">
            <asp:Label ID="lblil" runat="server"></asp:Label>
            -<asp:Label ID="lblilce" runat="server"></asp:Label>
        </div>
        <div class="profil_satir">
            <div class="profil_satir1">Meslek:</div>
            <div class="profil_satir2">
                <asp:Label ID="lblMeslek" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">Email:</div>

            <div class="profil_satir2">
                <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">Telefon:</div>

            <div class="profil_satir2">
                <asp:Label ID="lblTel" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">Telefon2:</div>

            <div class="profil_satir2">
                <asp:Label ID="lblTel2" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">GSM:</div>
            <div class="profil_satir2">
                <asp:Label ID="lblGsm" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">GSM2:</div>
            <div class="profil_satir2">
                <asp:Label ID="lblGsm2" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">FAX:</div>
            <div class="profil_satir2">
                <asp:Label ID="lblFax" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir3">Adres:</div>
            <div class="profil_satir4">
                <asp:Label ID="lblAdres" runat="server"></asp:Label>
            </div>
        </div>
        <div class="temizle"></div>

        <div class="profil_satir">
            <asp:Button ID="Button1" runat="server" Text="Profilini Düzenle" OnClick="Button1_Click" />
        </div>





    </div>
    <div id="Mesajlarim"></div>
    <div id="ilanlarim"></div>
</asp:Content>

