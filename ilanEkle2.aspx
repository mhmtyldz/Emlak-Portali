<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle2.aspx.cs" Inherits="ilanEkle2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <!-- Burada arsa özellikleri Bulunmaktadır -->
    <asp:panel id="pnlArsa" visible="False" runat="server">  
        <div class="ilan2_baslik">Arsa Genel Özellikler</div>
        <div class="ilan2_sol">İmar Durumu:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlimarDurumu" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        
        <div class="ilan2_sol">Kaks:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKaks" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        
        <div class="ilan2_sol">Gabari:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlGabari" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

       
        <div class="ilan2_sol">Tapu:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlTapu" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Kredi Durumu:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKredi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

       
        <div class="ilan2_sol">Metre Kare:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtMetre_Arsa" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Ada NO:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtAda" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Pafta NO:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtPafta" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Parsel NO:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtParsel" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Kat Karşılığı:</div>
        <div class="ilan2_sag"> 
           <asp:RadioButton runat="server" ID="rdEvet" GroupName="Kat" Text="Evet" Checked="True"></asp:RadioButton>
            <asp:RadioButton runat="server" ID="rdHayir" Text="Hayır" GroupName="Kat"></asp:RadioButton>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Metre Kare:</div>
        <div class="ilan2_sag"> 
           
         <asp:Button ID="btnArsaKaydet" runat="server" Text="Kaydet" OnClick="btnArsaKaydet_Click"></asp:Button>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

    </asp:panel>

    <!-- Burada Bina özellikleri Bulunmaktadır -->
    <asp:panel id="pnlBina" runat="server" Visible="False"> 

         <div class="ilan2_baslik">Bina Genel Özellikler</div>
        <div class="ilan2_sol">Binadaki Kat Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:TextBox ID="txtKatSayisi" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


        <div class="ilan2_sol">Kattaki Daire Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:TextBox ID="txtKattakiDaire" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->
        
        <div class="ilan2_sol">Isıtma Türü:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlisitma_Bina" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


        <div class="ilan2_sol">Metre Kare:</div>
        <div class="ilan2_sag"> 
            <asp:TextBox ID="txtMetre_Bina" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        
        <div class="ilan2_sol">Bina Yaşı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlBinaYasi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Metre Kare:</div>
        <div class="ilan2_sag"> 
          <asp:Button ID="btnBinaKaydet" runat="server" Text="Kaydet" OnClick="btnBinaKaydet_Click"></asp:Button>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->



       
     

    </asp:panel>


    <asp:panel id="pnlDevre"  runat="server" Visible="False">
        <div class="ilan2_baslik">Devremülk Genel Özellikler</div>
        <div class="ilan2_sol">Dönemi:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlDevreDonem" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


        
        <div class="ilan2_sol">Süresi:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlDevreSure" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


        <div class="ilan2_sol">Oda Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:TextBox ID="txtDevreOda" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Metre Kare:</div>
         <div class="ilan2_sag"> 
          <asp:Button ID="btnDevreKaydet" runat="server" Text="Kaydet" OnClick="btnDevreKaydet_Click"></asp:Button>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->





    </asp:panel>
    <asp:panel id="pnlKonut"  runat="server" Visible="False"> 
         
        <div class="ilan2_baslik">Konut Genel Özellikler</div>
        <div class="ilan2_sol">Isıtma Türü:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlisitma_Konut" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        
        <div class="ilan2_sol">Oda Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKonutOdasayisi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        
        <div class="ilan2_sol">Banyo Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKonutBanyoSayisi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

       
        <div class="ilan2_sol">Bina Yaşı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKonutBinaYasi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Kredi Durumu:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlKonutKredi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

       
        <div class="ilan2_sol">Binadaki Kat:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtKonutBinaKat" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Bulunduğu Kat:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtKonutKat" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Metre Kare:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtKonutMetre" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Bina Durumu:</div>
        <div class="ilan2_sag"> 
           <asp:DropDownList ID="ddlKonutBinaDurumu" runat="server"></asp:DropDownList>
        </div>
         <div class="ilan2_sol"><asp:Label ID="lblKonutBilgi" runat="server" Font-Size="16pt" ForeColor="#990000"></asp:Label></div>
        <div class="ilan2_sag"> 
           
         <asp:Button ID="btnKonutKaydet" runat="server" Text="Kaydet" OnClick="btnKonutKaydet_Click"></asp:Button>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->





    </asp:panel>
    <asp:panel id="pnlTuristik" runat="server" Visible="False"> 
        <div class="ilan2_baslik">Turistik Tesis Genel Özellikler</div>
        <div class="ilan2_sol">Yıldız Sayısı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlTuristYildiz" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

          <div class="ilan2_sol">Oda Sayısı:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristOda" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Yatak Sayısı:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristYatak" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Kat Sayısı:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristKat" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Bina Yaşı:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlTuristBinaYasi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Açık Alan:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristAcikAlan" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

         <div class="ilan2_sol">Kapalı Alan:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristKapaliAlan" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Zemin Etüdü:</div>
        <div class="ilan2_sag"> 
           <asp:RadioButton runat="server" ID="rdVar" GroupName="Zemin" Text="Var" Checked="True"></asp:RadioButton>
            <asp:RadioButton runat="server" ID="rdYok" Text="Yok" GroupName="Kat"></asp:RadioButton>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

        <div class="ilan2_sol">Kredi Durumu:</div>
        <div class="ilan2_sag"> 
            <asp:DropDownList ID="ddlTuristKredi" runat="server"></asp:DropDownList>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


        <div class="ilan2_sol">Apart Sayısı:</div>
        <div class="ilan2_sag"> 
           <asp:TextBox ID="txtTuristApart" runat="server"></asp:TextBox>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->

           <div class="ilan2_sag"> 
           
         <asp:Button ID="btnTuristKaydet" runat="server" Text="Kaydet" OnClick="btnTuristKaydet_Click"></asp:Button>
        </div>
        <div class="temizle"></div><!-- Burda da Satırlar Bitmiştir -->


    </asp:panel>

</asp:Content>

