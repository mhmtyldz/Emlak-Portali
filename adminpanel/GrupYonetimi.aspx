<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/master_admin.master" AutoEventWireup="true" CodeFile="GrupYonetimi.aspx.cs" Inherits="adminpanel_GrupYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }

        .auto-style2 {
            width: 147px;
        }

        .auto-style3 {
            width: 600px;
        }

        .auto-style5 {
            width: 256px;
            height: 256px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td width="20%" class="auto-style2" style="font-weight: bold; font-family: Verdana; font-size: 15px">Grup Adı:</td>
            <td>
                <asp:TextBox ID="txt_GrupAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" Font-Bold="True" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>





    <table align="center" class="auto-style3">
        <asp:Repeater ID="rpGruplar" runat="server">
            <ItemTemplate>

                <tr>

                    <td style="width: 60%">
                        <%#Eval("GrupAdi") %>

                    </td>
                    <td style="width: 20%">
                       
                      <a href="GrupGuncelle.aspx?GrupId=<%#Eval("GrupId") %>"> <img border="0" align="middle" width="30" src="images/iconlar/kul_duzenle.png" /></a> 
                    </td>

                    <td style="width: 20%">
                        
                     <a href="GrupYonetimi.aspx?GrupId=<%# Eval("GrupId") %>&islem=sil"><img border="0" align="middle" width="30" src="images/iconlar/kul_sil.png" /></a>   

                    </td>
                </tr>

            </ItemTemplate>

        </asp:Repeater>

    </table>





</asp:Content>

