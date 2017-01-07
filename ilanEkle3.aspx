<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle3.aspx.cs" Inherits="ilanEkle3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:panel visible="false"  id="pnlAktivite" runat="server">
    <div class="AyrOzellik_Baslik">Aktiviteler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist ID="chckAktivite" runat="server" RepeatColumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>

    <asp:panel visible="false" id="pnlAltYapi" runat="server">
    <div class="AyrOzellik_Baslik">Alt Yapı</div>
    <div class="AyrOzellik">
        <asp:checkboxlist ID="chckAltYapi" runat="server" RepeatColumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>

    <asp:panel visible="false" id="pnlBanyoOzellikler" runat="server">
    <div class="AyrOzellik_Baslik">Banyo Özellikler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckBanyoOzellikler" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


    <asp:panel visible="false" id="pnlBinaDetay" runat="server">
    <div class="AyrOzellik_Baslik">Bina Detay</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckBinaDetay" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


    <asp:panel visible="false" id="pnlCephe" runat="server">
    <div class="AyrOzellik_Baslik">Cephe</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckCephe" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlDisOzellikler" runat="server">
    <div class="AyrOzellik_Baslik">Dış Özellikler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckDisOzellikler" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>




    <asp:panel visible="false" id="pnlicOzellikler" runat="server">
    <div class="AyrOzellik_Baslik">İç Özellikler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckicOzellikler" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


    <asp:panel visible="false" id="pnlKampDetay" runat="server">
    <div class="AyrOzellik_Baslik">Kamp Detay</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckKampDetay" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


    <asp:panel visible="false" id="pnlManzara" runat="server">
    <div class="AyrOzellik_Baslik">Manzara</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckManzara" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


    <asp:panel visible="false" id="pnlMuhit" runat="server">
    <div class="AyrOzellik_Baslik">Muhit</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckMuhit" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlMutfak" runat="server">
    <div class="AyrOzellik_Baslik">Mutfak</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckMutfak" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlOdaOzellikler" runat="server">
    <div class="AyrOzellik_Baslik">Oda Özellikler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckOdaOzellikler" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlOdaTipi" runat="server">
    <div class="AyrOzellik_Baslik">Oda Tipi</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckOdaTipi" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>




    <asp:panel visible="false" id="pnlOrtakKullanimAlani" runat="server">
    <div class="AyrOzellik_Baslik">Ortak Kullanım Alanları</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckOrtakKullanimAlani" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlParsel" runat="server">
    <div class="AyrOzellik_Baslik">Parsel Durumu</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckParsel" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>



    <asp:panel visible="false" id="pnlTesisDetay" runat="server">
    <div class="AyrOzellik_Baslik">Tesis Detay</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckTesisDetay" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>




    <asp:panel visible="false" id="pnlUlasim" runat="server">
    <div class="AyrOzellik_Baslik">Ulaşım</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckUlasim" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>





    <asp:panel visible="false" id="pnlYeme" runat="server">
    <div class="AyrOzellik_Baslik">Yeme</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckYeme" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


     <asp:panel visible="false" id="pnlResidenceOzellik" runat="server">
    <div class="AyrOzellik_Baslik">Residence Özellikler</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckResidenceOzellik" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>


     <asp:panel visible="false" id="pnlResidenceSosyalOzellik" runat="server">
    <div class="AyrOzellik_Baslik">Residence Sosyal Olanaklar</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckResidenceSosyalOzellik" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>

       <asp:panel visible="false" id="pnlKonutTipi" runat="server">
    <div class="AyrOzellik_Baslik">Konut Tipi</div>
    <div class="AyrOzellik">
        <asp:checkboxlist id="chckKonutTipi" runat="server" repeatcolumns="7"></asp:checkboxlist>
    </div>
    </asp:panel>

    <div style="text-align: center; padding-top: 15px;">
        <strong>
        <asp:Button ID="btnKaydet" runat="server" Text="Button" OnClick="btnKaydet_Click" style="font-weight: bold" />
        </strong>
    </div>

</asp:Content>

