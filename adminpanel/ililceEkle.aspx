<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="ililceEkle.aspx.cs" Inherits="adminpanel_ililceEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 500px;
        }

        .auto-style3 {
            width: 25%;
            height: 28px;
        }

        .auto-style4 {
            width: 10%;
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td style="width: 25%">
                            <asp:Button ID="btnilEkle" runat="server" Text="İl Ekle" OnClick="btnilEkle_Click" />
                        </td>
                        <td style="width: 25%">
                            <asp:Button ID="btnilceEkle" runat="server" Text="İlçe Ekle" OnClick="btnilceEkle_Click" />
                        </td>
                        <td style="width: 25%">
                            <asp:Button ID="btnSemtEkle" runat="server" Text="Semt Ekle" OnClick="btnSemtEkle_Click" />
                        </td>
                        <td style="width: 25%">
                            <asp:Button ID="btnMahalleEkle" runat="server" Text="Mahalle Ekle" OnClick="btnMahalleEkle_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlil" runat="server" Visible="False">
                    <table class="auto-style2">
                        <tr>
                            <td style="width: 150px">
                                <asp:TextBox ID="txtil1" runat="server"></asp:TextBox>
                            </td>
                            <td style="width: 100px">
                                <asp:Button ID="btn_ilEkle" runat="server" Text="Ekle" OnClick="btn_ilEkle_Click" />
                            </td>
                            <td style="width: 250px">
                                <asp:Label ID="lblBilgi1" runat="server" ForeColor="#990000" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlilce" runat="server" Visible="False">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:DropDownList ID="ddlil" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtilce" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style4">
                                <asp:Button ID="btn_ilceEkle" runat="server" Text="Ekle" OnClick="btn_ilceEkle_Click" />
                            </td>
                            <td class="auto-style3" style="width: 40%">
                                <asp:Label ID="lblBilgi2" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlSemt" runat="server" Visible="False">
                    <table class="auto-style1">
                        <tr>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddlil2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil2_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddlilce2" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 15%">
                                <asp:TextBox ID="txtSemt" runat="server"></asp:TextBox>
                            </td>
                            <td style="width: 10%">
                                <asp:Button ID="btn_semtEkle" runat="server" OnClick="btn_semtEkle_Click" Text="Ekle" />
                            </td>
                            <td style="width: 65%">
                                <asp:Label ID="lblBilgi3" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlMahalle" runat="server" Visible="False">  
                     <table class="auto-style1">
                    <tr>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddlil3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddlilce3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlilce3_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 20%">
                            <asp:DropDownList ID="ddlsemt" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 15%">
                            <asp:TextBox ID="txtMahalle" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 10%">
                            <asp:Button ID="btn_mahalleEkle" runat="server" OnClick="btn_mahalleEkle_Click" Text="Ekle" />
                        </td>
                        <td>
                            <asp:Label ID="lblBilgi4" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
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
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

