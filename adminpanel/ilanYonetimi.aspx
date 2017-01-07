<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="ilanYonetimi.aspx.cs" Inherits="adminpanel_ilanYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            font-size: 12px;
        }

        .auto-style2 {
            width: 20%;
        }

        .auto-style3 {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:DropDownList ID="ddlOnayli" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Selected="True">Onaysız</asp:ListItem>
                    <asp:ListItem>Onaylı</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlOnaysiz" runat="server" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 20%; text-align: center;">İlan Resmi</td>
                                <td style="width: 35%">İlanın Adı</td>
                                <td style="width: 15%">İlan Türü</td>
                                <td style="width: 20%">Ekleyen</td>
                                <td style="width: 5%; text-align: center;">Onayla</td>
                                <td style="width: 5%; text-align: center;">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 20%; text-align: center;">
                                    <img width="80" height="80" src="../ilanResimleri/200/<%#Eval("VitrinResim ") %>" />
                                </td>
                                <td style="width: 35%"><%#Eval("Baslik") %></td>
                                <td style="width: 15%"><%#Eval("TurAdi") %></td>
                                <td class="auto-style2"><%#Eval("AdSoyad") %></td>
                                <td style="width: 5%; text-align: center;">
                                    <a href="ilanYonetimi.aspx?ilanId=<%#Eval("ilanId")%>&islem=Onay">
                                        <img border="0" src="images/iconlar/apply.png" /></a>
                                </td>
                                <td style="width: 5%; text-align: center;">
                                   <a href="ilanYonetimi.aspx?ilanId=<%#Eval("ilanId")%>&islem=Sil">
                                        <img border="0" src="images/iconlar/delete.png" /></a>
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
            <td class="auto-style3">
                <asp:DataList ID="dlOnayli" runat="server" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 20%; text-align: center;">İlan Resmi</td>
                                <td style="width: 40%">İlanın Adı</td>
                                <td style="width: 15%">İlan Türü</td>
                                <td style="width: 20%">Ekleyen</td>

                                <td style="width: 5%; text-align: center;">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 20%; text-align: center;">
                                    <img width="80" height="80" src="../ilanResimleri/200/<%#Eval("VitrinResim ") %>" />
                                </td>
                                <td style="width: 35%"><%#Eval("Baslik") %></td>
                                <td style="width: 15%"><%#Eval("TurAdi") %></td>
                                <td class="auto-style2"><%#Eval("AdSoyad") %></td>

                                <td style="width: 5%; text-align: center;">
                                    <img src="images/iconlar/delete.png" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

