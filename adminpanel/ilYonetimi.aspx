<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="ilYonetimi.aspx.cs" Inherits="adminpanel_ilYonetimi" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 22px;
        }

        .auto-style3 {
            width: 700px;
        }

        .auto-style4 {
            text-align: center;
        }

        .auto-style5 {
            width: 600px;
        }

        .auto-style6 {
            width: 40%;
            height: 22px;
        }

        .auto-style7 {
            width: 600px;
        }
        .auto-style8 {
            height: 36px;
        }
        .auto-style9 {
            width: 300px;
        }
        .auto-style10 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" ForeColor="#990000" OnClick="LinkButton1_Click">il-ilce-Semt EKLE</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <table align="center" class="auto-style3">
                    <tr>
                        <td class="auto-style4" style="width: 25%">
                            <asp:button id="Button1" runat="server" text="İl Düzenle" onclick="Button1_Click" />
                        </td>
                        <td class="auto-style4" style="width: 25%">
                            <asp:button id="Button2" runat="server" text="İlçe Düzenle" OnClick="Button2_Click" />
                        </td>
                        <td class="auto-style4" style="width: 25%">
                            <asp:button id="Button3" runat="server" text="Semt Düzenle" OnClick="Button3_Click" />
                        </td>
                        <td class="auto-style4" style="width: 25%">
                            <asp:button id="Button4" runat="server" text="Mahalle Düzenle" OnClick="Button4_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:ModalPopupExtender BackgroundCssClass="sayfaarkaplan" CancelControlID="btnHayiril"  PopupControlID="pnlilSil" TargetControlID="btnilSil" ID="ModalPopupExtender1" runat="server">

                </asp:ModalPopupExtender>
                <asp:panel id="pnlil" visible="false" runat="server">
                    <table class="auto-style5">
                    <tr>
                        <td class="auto-style6" style="width: 30%">
                            <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style6" style="width: 30%">
                            <asp:TextBox ID="txtil" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style6" style="width: 20%">
                            <asp:Button ID="guncelleil" runat="server" Text="Güncelle" OnClick="guncelleil_Click" />
                        </td>
                        <td class="auto-style6" style="width: 20%">
                            <asp:Button ID="btnilSil" runat="server" Text="Sil" />
                        </td>
                    </tr>
                </table>
                    <asp:Panel ID="pnlilSil" Width="300px" Height="70px"  runat="server" BackColor="#99CCFF" BorderColor="Blue" BorderStyle="Solid">

                        <table align="center" class="auto-style9">
                            <tr>
                                <td class="auto-style10" colspan="2">İli Siilmek istediğinizden Emin misiniz ?</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    <asp:Button ID="btnEvetil" runat="server" Text="Evet" OnClick="btnEvetil_Click" />
                                </td>
                                <td class="auto-style4">
                                    <asp:Button ID="btnHayiril" runat="server" Text="Hayır" />
                                </td>
                            </tr>
                        </table>

                    </asp:Panel>
                </asp:panel>


            </td>
        </tr>
        <tr>
            <td>

                <asp:panel runat="server" ID="pnlilce" Visible="False">  
                <table class="auto-style7">
                    <tr>
                        <td style="width: 25%">
                            <asp:DropDownList ID="ddl_ilce_il" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_ilce_il_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 25%">
                            <asp:DropDownList ID="ddl_ilce" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddl_ilce_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 25%">
                            <asp:TextBox ID="txtilce" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnGuncelleilce" runat="server" OnClick="btnGuncelleilce_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>

                </asp:panel>


            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:panel ID="pnlsemt" runat="server" Visible="False">

                       <table class="auto-style7">
                    <tr>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddl_il3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_il3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddl_ilce3" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddl_ilce3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddl_semt" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddl_semt_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:TextBox ID="txt_semt" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 20%">
                            <asp:Button ID="btnGuncelleSemt" runat="server" OnClick="btnGuncelleSemt_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>


                </asp:panel>
                <asp:panel ID="pnlMahalle" runat="server" Visible="False">  
                    <table class="auto-style1">
                    <tr>
                        <td style="width: 15%">
                            <asp:DropDownList ID="ddlil4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 15%">
                            <asp:DropDownList ID="ddlilce4" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlilce4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 15%">
                            <asp:DropDownList ID="ddlsemt4" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlsemt4_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 15%">
                            <asp:DropDownList ID="ddlmahalle4" runat="server" Enabled="False" OnSelectedIndexChanged="ddlmahalle4_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:TextBox ID="txtMahalle" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 20%">
                            <asp:Button ID="btnMahalleGuncelle" runat="server"  Text="Güncelle" OnClick="btnMahalleGuncelle_Click" />
                        </td>
                    </tr>
                </table>

                </asp:panel>

                

                <table>

                </table>
             
            </td>
        </tr>
    </table>
</asp:Content>

