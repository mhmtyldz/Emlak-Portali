<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="VitrinYonetimi.aspx.cs" Inherits="adminpanel_VitrinYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            font-size: 12px;
        }

        .auto-style2 {
            width: 16%;
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
                <asp:Panel ID="Panel1" runat="server" DefaultButton="btnAra">
                    <table class="auto-style1">
                        <tr>
                            <td style="width: 30%; font-family: 'Trebuchet MS'; font-size: 14px; font-weight: bold; color: #0033CC;">Aramak İstediğiniz Kriteri Girin</td>
                            <td style="width: 25%">
                                <asp:DropDownList ID="ddlAra" runat="server">
                                    <asp:ListItem Selected="True">İlan Adına Göre</asp:ListItem>
                                    <asp:ListItem>İlan Nosuna G&#246;re</asp:ListItem>
                                    <asp:ListItem>Ad Soyada Göre</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td style="width: 45%">
                                <asp:TextBox ID="txtAra" runat="server" Height="16px" Width="305px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnAra" runat="server" OnClick="btnAra_Click" Text="İlan Ara" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            
            <td>
                <asp:DataList ID="dlAra" runat="server" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%">İlan No</td>
                                <td style="width: 15%; text-align: center;">İlan Resmi</td>
                                <td style="width: 26%">İlanın Adı</td>
                                <td style="width: 15%">İlan Türü</td>
                                <td style="width: 16%">Ekleyen</td>
                                <td style="width: 10%; text-align: center;">İlçe Vitrini</td>
                                <td style="width: 10%; text-align: center;">Vitrin</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%"><%#Eval("ilanId") %></td>
                                <td style="width: 15%; text-align: center;">
                                    <img width="80" height="80" src="../ilanResimleri/200/<%#Eval("VitrinResim ") %>" />
                                </td>
                                <td style="width: 26%"><%#Eval("Baslik") %></td>
                                <td style="width: 15%"><%#Eval("TurAdi") %></td>
                                <td class="auto-style2"><%#Eval("AdSoyad") %></td>
                                <td style="width: 10%; text-align: center;">
                                    <%#Methodlar.vitrin(Eval("Vitrinilce").ToString()) %> &nbsp;  
                                    <a href="VitrinYonetimi.aspx?islem=ilcevitrin&ilanId=<%#Eval("ilanId") %>">
                                    <img border="0" align="middle" height="23" src="images/iconlar/apply.png" />

                                </a>
                                </td>
                                <td style="width: 10%; text-align: center;">
                                    <%#Methodlar.vitrin(Eval("Vitrin").ToString())%> <a href="VitrinYonetimi.aspx?islem=vitrin&ilanId=<%#Eval("ilanId") %>">
                                    <img border="0" align="middle" height="23" src="images/iconlar/apply.png" />

                                </a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlVitrin" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlVitrin_SelectedIndexChanged">
                    <asp:ListItem>Seçiniz</asp:ListItem>
                    <asp:ListItem>Vitrin</asp:ListItem>
                    <asp:ListItem>İlçe Vitrin</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlilce" runat="server" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="ddlilce_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlVitrin" runat="server" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" Width="100%" Visible="False">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%">İlan No</td>
                                <td style="width: 15%; text-align: center;">İlan Resmi</td>
                                <td style="width: 36%">İlanın Adı</td>
                                <td style="width: 15%">İlan Türü</td>
                                <td style="width: 16%">Ekleyen</td>
                                <td style="width: 10%; text-align: center;">Çıkar</td>
                                
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%"><%#Eval("ilanId") %></td>
                                <td style="width: 15%; text-align: center;">
                                    <img width="80" height="80" src="../ilanResimleri/200/<%#Eval("VitrinResim ") %>" />
                                </td>
                                <td style="width: 36%"><%#Eval("Baslik") %></td>
                                <td style="width: 15%"><%#Eval("TurAdi") %></td>
                                <td class="auto-style2"><%#Eval("AdSoyad") %></td>
                                <td style="width: 10%; text-align: center;">
                                    
                                    <a href="VitrinYonetimi.aspx?islem=vitrincikar&ilanId=<%#Eval("ilanId") %>">
                                    <img border="0" align="middle" height="23" src="images/iconlar/delete.png" />

                                </a>
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
            <td>
                <asp:DataList ID="dlilceVitrin" runat="server" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" Width="100%" Visible="False">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%">İlan No</td>
                                <td style="width: 15%; text-align: center;">İlan Resmi</td>
                                <td style="width: 36%">İlanın Adı</td>
                                <td style="width: 15%">İlan Türü</td>
                                <td style="width: 16%">Ekleyen</td>
                                <td style="width: 10%; text-align: center;">Çıkar</td>
                                
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td style="width: 8%"><%#Eval("ilanId") %></td>
                                <td style="width: 15%; text-align: center;">
                                    <img width="80" height="80" src="../ilanResimleri/200/<%#Eval("VitrinResim ") %>" />
                                </td>
                                <td style="width: 36%"><%#Eval("Baslik") %></td>
                                <td style="width: 15%"><%#Eval("TurAdi") %></td>
                                <td class="auto-style2"><%#Eval("AdSoyad") %></td>
                                <td style="width: 10%; text-align: center;">
                                    
                                    <a href="VitrinYonetimi.aspx?islem=ilcevitrincikar&ilanId=<%#Eval("ilanId") %>">
                                    <img border="0" align="middle" height="23" src="images/iconlar/delete.png" />

                                </a>
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

