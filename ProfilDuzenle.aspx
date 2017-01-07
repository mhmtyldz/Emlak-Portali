<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ProfilDuzenle.aspx.cs" Inherits="ProfilDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="Kul_bilgi">
        <div id="profil_resim">
            <asp:Image Height="150" ID="imgResim" runat="server" />

        </div>
        <div class="profil_satir">
            <div class="profil_satir1">Resim:</div>
            <div class="profil_satir2">

                <asp:FileUpload ID="fuResim" runat="server" />
            </div>
        </div>
        <div class="temizle"></div>

        <div class="profil_satir">
            <div class="profil_satir1">Ad Soyad:</div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtAdSoyad" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="profil_satir">
                    <div class="profil_satir1">İl:</div>
                    <div class="profil_satir2">
                        <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="temizle"></div>
                <div class="profil_satir">
                    <div class="profil_satir1">İlçe:</div>
                    <div class="profil_satir2">
                        <asp:DropDownList ID="ddlilce" runat="server" >
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="temizle"></div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <div class="profil_satir">
            <div class="profil_satir1">Meslek:</div>
            <div class="profil_satir2">
                <asp:DropDownList ID="ddlMeslek" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <div class="temizle"></div>

        <div class="profil_satir">
            <div class="profil_satir1">Telefon:</div>

            <div class="profil_satir2">
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">Telefon2:</div>

            <div class="profil_satir2">
                <asp:TextBox ID="txtTel2" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">GSM:</div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtGsm" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">GSM2:</div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtGsm2" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir1">FAX:</div>
            <div class="profil_satir2">
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>
        <div class="profil_satir">
            <div class="profil_satir3">Adres:</div>
            <div class="profil_satir4">
                <asp:TextBox ID="txtAdres" runat="server" Height="30px" TextMode="MultiLine" Width="327px"></asp:TextBox>
            </div>
        </div>
        <div class="temizle"></div>

        <div class="profil_satir">
            <asp:Button ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
        </div>





    </div>
</asp:Content>

