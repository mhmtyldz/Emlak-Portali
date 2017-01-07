<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="adminpanel_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 400px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body style="background-color: #97BFFC">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: Arial, Helvetica, sans-serif; font-size: 16px; font-weight: bold; color: #336699; text-align: center">AnkaraEvBul.com Yönetim Paneli</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td>
                    <table align="center" class="auto-style3" style="border: medium double #0066CC; font-size: 16px; font-weight: bold; ">
                        <tr>
                            <td class="auto-style2" colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2" colspan="2">
                                <asp:Label ID="lblBilgi" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 30%">Kullanıcı Adı:</td>
                            <td>
                                <asp:TextBox  ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Şifre:</td>
                            <td>
                                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button class="btn btn-default" ID="btnGiris" runat="server" OnClick="btnGiris_Click" Text="Giriş" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
