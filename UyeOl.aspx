<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="UyeOl.aspx.cs" Inherits="UyeOl" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div style="font-size: 12px; font-weight: bold; font-family: arial, Helvetica, sans-serif; color: #990000; text-align: center">
        <asp:Label ID="lblBilgi" runat="server" Text=""></asp:Label>
    </div>
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Üyelik Türü:</div>

        <div class="uyeol_orta">
            <asp:RadioButton ID="rdKullanici" Text="Kullanıcı" runat="server" Checked="True" GroupName="Grup" /><asp:RadioButton ID="rdEmlakci" Text="Emlakçı" runat="server" GroupName="Grup" />
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Email:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtEmail" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Şifre</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtSifre" runat="server" Height="20px" Width="180px" TextMode="Password"></asp:TextBox>
        </div>

        <div class="uyeol_sag">

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSifre" CssClass="hata_mesaj">Şifre Boş Geçilemez!</asp:RequiredFieldValidator>

        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Şifre(Tekrar):</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtSifre2" runat="server" Height="20px" Width="180px" TextMode="Password"></asp:TextBox>
        </div>

        <div class="uyeol_sag">

            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtSifre" ControlToValidate="txtSifre2" CssClass="hata_mesaj">Şifreler Uyuşmuyor!</asp:CompareValidator>

        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Ad Soyad:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtAdSoyad" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdSoyad" CssClass="hata_mesaj">Ad Soyad Boş Geçilemez!</asp:RequiredFieldValidator>

        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Gsm:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtGsm" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Gsm2:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtGsm2" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Telefon:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtTel" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Telefon2:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtTel2" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->
    <div class="Uyeol_satir">
        <div class="uyeol_sol">Fax:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtFax" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Meslek:</div>

        <div class="uyeol_orta">
            <asp:DropDownList ID="ddlMeslek" runat="server">
            </asp:DropDownList>
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Cinsiyet:</div>

        <div class="uyeol_orta">
            <asp:RadioButton ID="rdErkek" runat="server" Text="Erkek" Checked="True" GroupName="cinsiyet" />
            <asp:RadioButton ID="rdBayan" runat="server" Text="Bayan" GroupName="cinsiyet" />
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <asp:UpdatePanel runat="server" ID="UpdatePanel1">

        <ContentTemplate>





            <div class="Uyeol_satir">
                <div class="uyeol_sol">İl:</div>

                <div class="uyeol_orta">
                    <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>

                <div class="uyeol_sag">
                </div>
            </div>
            <div class="Uyeol_satir">
                <div class="uyeol_sol">İlçe:</div>

                <div class="uyeol_orta">
                    <asp:DropDownList ID="ddlilce" runat="server" Enabled="False">
                    </asp:DropDownList>
                </div>

                <div class="uyeol_sag">
                </div>
            </div>
            <!-- Uye ol Satır bitti-->

        </ContentTemplate>

    </asp:UpdatePanel>

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Doğum Tarihi:</div>

        <div class="uyeol_orta">
            <asp:TextBox ID="txtDogum" runat="server" Height="20px" Width="180px"></asp:TextBox>
        </div>

        <div class="uyeol_sag">
        </div>

    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir">
        <div class="uyeol_sol">Resim:</div>

        <div class="uyeol_orta">
            <asp:FileUpload ID="fuResim" runat="server" />
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

    <div class="Uyeol_satir2">
        <div class="uyeol_sol">Adres:</div>

        <div class="uyeol_orta">

            <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine" Height="125px" Width="200px"></asp:TextBox>

        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->


    <div class="Uyeol_satir">
        <div class="uyeol_sol"></div>

        <div class="uyeol_orta">
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
        </div>

        <div class="uyeol_sag">
        </div>
    </div>
    <!-- Uye ol Satır bitti-->

</asp:Content>

