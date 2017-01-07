<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="AdminYonetimi.aspx.cs" Inherits="adminpanel_AdminYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 300px;
        }
        .auto-style3 {
            height: 22px;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <table align="left" class="auto-style2">
                    <tr>
                        <td style="width: 40%">Kullanıcı Adı:</td>
                        <td>
                            <asp:TextBox ID="txtAra" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnAra" runat="server" Text="Ara" OnClick="btnAra_Click" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblAra" runat="server" Font-Size="11pt" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlAra" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1" style="font-size: 13px">
                            <tr>
                                <td style="width: 30%">Kullanıcı Adı</td>
                                <td style="width: 30%">Ad Soyad</td>
                                <td style="width: 20%">Görevi</td>
                                <td style="width: 10%">Düzenle</td>
                                <td style="width: 10%">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1" style="font-size: 13px">
                            <tr>
                                <td style="width: 30%"><%#Eval("KullaniciAdi") %></td>
                                <td style="width: 30%"><%#Eval("AdSoyad") %></td>
                                <td style="width: 20%"><%#Eval("GrupAdi") %></td>
                                <td style="width: 10%">
                                  <a href="KullaniciDuzenle.aspx?KullaniciId=<%#Eval("KullaniciId") %>"> <img border="0" height="30" src="images/iconlar/kul_duzenle.png" /></a> 
                                </td>
                                <td style="width: 10%">
                                  <a href="AdminYonetimi.aspx?KullaniciId=<%#Eval("KullaniciId") %>&islem=sil">   <img border="0" height="30" src="images/iconlar/kul_sil.png" /></a>

                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Button ID="btnYonetici" runat="server" OnClick="btnYonetici_Click" Text="Yöneticiler" />
                        </td>
                        <td>
                            <asp:Button ID="btnYardimci" runat="server" Text="Yardımcı Yönetici" OnClick="btnYardimci_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnEmlakci" runat="server" Text="Emlakçılar" OnClick="btnEmlakci_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnKullanici" runat="server" Text="Kullanıcılar" OnClick="btnKullanici_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnSon" runat="server" Text="Son 20 Üye" OnClick="btnSon_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlKullanici" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1" style="font-size: 13px">
                            <tr>
                                <td style="width: 30%">Kullanıcı Adı</td>
                                <td style="width: 30%">Ad Soyad</td>
                                <td style="width: 20%">Görevi</td>
                                <td style="width: 10%">Düzenle</td>
                                <td style="width: 10%">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1" style="font-size: 13px">
                            <tr>
                                <td style="width: 30%"><%#Eval("KullaniciAdi") %></td>
                                <td style="width: 30%"><%#Eval("AdSoyad") %></td>
                                <td style="width: 20%"><%#Eval("GrupAdi") %></td>
                                <td style="width: 10%">
                                <a href="KullaniciDuzenle.aspx?KullaniciId=<%#Eval("KullaniciId") %>"><img border="0" height="30" src="images/iconlar/kul_duzenle.png" /></a>    
                                </td>
                                <td style="width: 10%">
                                 <a href="AdminYonetimi.aspx?KullaniciId=<%#Eval("KullaniciId") %>&islem=sil"> <img border="0" height="30" src="images/iconlar/kul_sil.png" /></a>  

                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

