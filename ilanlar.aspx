<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ilanlar.aspx.cs" Inherits="ilanlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="ilanlar_sol">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="ilanlar_sol_baslik">İLçe Adı</div>
                <div class="ilanlar_sol_ddl">
                    <asp:DropDownList ID="ddlilce" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlilce_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="ilanlar_sol_ddl">
                    <asp:LinkButton ID="lbilceKaldir" runat="server" OnClick="lbilceKaldir_Click">Seçimi Kaldır</asp:LinkButton>
                </div>


                <div class="ilanlar_sol_baslik">Tür Adı</div>
                <div class="ilanlar_sol_ddl">
                    <asp:DropDownList ID="ddlTur" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTur_SelectedIndexChanged"></asp:DropDownList>

                </div>
                <div class="ilanlar_sol_ddl">
                    <asp:LinkButton ID="lbTurKaldir" runat="server" OnClick="lbTurKaldir_Click">Seçimi Kaldır</asp:LinkButton></div>
                <div class="ilanlar_sol_ddl">&nbsp;</div>
                <div class="ilanlar_sol_baslik">Alt Tür Adı</div>
                <div class="ilanlar_sol_ddl">
                    <asp:DropDownList ID="ddlAltTur" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAltTur_SelectedIndexChanged"></asp:DropDownList>
                    <div class="ilanlar_sol_ddl">
                        <asp:LinkButton ID="lbAltTurKaldir" runat="server" OnClick="lbAltTurKaldir_Click">Seçimi Kaldır</asp:LinkButton></div>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
        <div class="ilanlar_sol_ddl">&nbsp;</div>

        <div class="ilanlar_sol_ddl">&nbsp;</div>
        <div class="ilanlar_sol_ddl">
            <asp:Button ID="btnListele" runat="server" Text="Listele" OnClick="btnListele_Click" />

        </div>


    </div>
    <div id="ilanlar_sag">
        <div class="ilanlar_satir_baslik">
            <div class="ilanlar_sayi2">İlan No</div>
            <div class="ilanlar_resim2">Resim</div>
            <div class="ilanlar_AltTur2">Tür</div>
            <div class="ilanlar_islem2">İşlem</div>
            <div class="ilanlar_baslik2">İlan Başlık</div>
            <div class="ilanlar_fiyat2">Fiyat</div>
            <div class="ilanlar_tarih2">Eklenme Tarihi</div>
            <div class="ilanlar_ilce2">İlçe</div>
        </div>

        <asp:Repeater ID="rpilanlar" runat="server">
            <ItemTemplate>
                <div class="ilanlar_satir">
                    <div class="ilanlar_sayi"><%#Eval("ilanId") %></div>
                    <div class="ilanlar_resim">
                        <img height="80" width="80" src="ilanResimleri/200/<%#Eval("VitrinResim") %>" />
                    </div>
                    <div class="ilanlar_AltTur"><%#Eval("AltTurAdi") %></div>
                    <div class="ilanlar_islem"><%#Eval("islem") %></div>
                    <div class="ilanlar_baslik"><%#Eval("Baslik") %></div>
                    <div class="ilanlar_fiyat"><%#Eval("Fiyat") %>&nbsp; <%#Eval("FiyatTur") %> </div>
                    <div class="ilanlar_tarih"><%#Eval("Tarih") %></div>
                    <div class="ilanlar_ilce"><%#Eval("ilceAdi") %></div>
                </div>

            </ItemTemplate>
        </asp:Repeater>

    </div>
    <div class="temizle"></div>


</asp:Content>

