<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="KullaniciDuzenle.aspx.cs" Inherits="adminpanel_KullaniciDuzenle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBilgi" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table class="auto-style2">
                    <tr>
                        <td style="width: 25%">Kullanıcı Adı:</td>
                        <td>
                            <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre:</td>
                        <td>
                            <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre2:</td>
                        <td>
                            <asp:TextBox ID="txtSifre2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Ad Soyad:</td>
                        <td>
                            <asp:TextBox ID="txtAdSoyad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Görevi:</td>
                        <td>
                            <asp:DropDownList ID="ddlGorevi" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>eMail:</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>İli:</td>
                        <td rowspan="2">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                     <table class="auto-style1">
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged1">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlilce" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                           

                        </td>
                    </tr>
                    <tr>
                        <td>İlçesi:</td>
                    </tr>
                    <tr>
                        <td>Telefon:</td>
                        <td>
                            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Telefon2:</td>
                        <td>
                            <asp:TextBox ID="txtTel2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Gsm:</td>
                        <td>
                            <asp:TextBox ID="txtGsm" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Gsm2:</td>
                        <td>
                            <asp:TextBox ID="txtGsm2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Fax:</td>
                        <td>
                            <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Cinsiyet:</td>
                        <td>
                            <asp:RadioButton ID="rdErkek" runat="server" Checked="True" GroupName="Cinsiyet" Text="Erkek"  />
                            <asp:RadioButton ID="rdBayan" runat="server" GroupName="Cinsiyet" Text="Bayan" />
                        </td>
                    </tr>
                    <tr>
                        <td>Doğum Tarih</td>
                        <td>
                            <asp:TextBox ID="txtDogum" runat="server"></asp:TextBox>
                            <asp:CalendarExtender DefaultView="Years"   TargetControlID="txtDogum"  runat="server">

                            </asp:CalendarExtender>

                        </td>
                    </tr>
                    <tr>
                        <td>Adres:</td>
                        <td>
                            <asp:TextBox ID="txtAdres" runat="server" Height="115px" TextMode="MultiLine" Width="240px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Engelleme:</td>
                        <td>
                            <asp:RadioButton ID="rdEvet" runat="server" GroupName="Engel" Text="Evet" />
                            <asp:RadioButton ID="rdHayir" runat="server" GroupName="Engel" Text="Hayır" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnGuncelle" runat="server" Height="26px" Text="Güncelle" Width="90px" OnClick="btnGuncelle_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

