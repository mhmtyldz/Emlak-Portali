<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="SifremiUnuttum.aspx.cs" Inherits="SifremiUnuttum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="Sifremi_unuttum">
        <asp:Label ID="lblEmail" runat="server" Text="Kullanıcı Bilgilerini Almak istediğiniz Mail Adresini giriniz! "></asp:Label>

    </div>

    <div style="text-align: center">
        <asp:TextBox ID="txtEmail" runat="server" Width="170px"></asp:TextBox>
    </div>
    <div style="text-align:center; ">
        <asp:Button ID="btnGonder" runat="server" Text="Gönder" OnClick="btnGonder_Click" />
    </div>
</asp:Content>

