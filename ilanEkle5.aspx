﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle5.aspx.cs" Inherits="ilanEkle5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="ilan_tamam_ad">
        Sayın <asp:Literal ID="ltrlAdSoyad" runat="server"></asp:Literal>
    </div>
    <div class="ilan_tamam">
        <asp:Literal ID="ltrlilanId" runat="server"></asp:Literal> Nolu ilanınız Başarıyla Kaydedilmiştir. Onaylandıktan sonra Sitemiz de Görüntülenecektir.
    </div>
</asp:Content>

