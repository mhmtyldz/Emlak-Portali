<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="butonlar">
        <div id="daire_buton">
            <div id="daire_icon">
                <div id="icon_ev">
                    &nbsp;<a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image1','','images/icon_ev2.png',1)"><img src="images/icon_ev.png" width="84" height="88" id="Image1" /></a>
                </div>

            </div>
            <div id="daire_satilik">
                <div class="satilik">SATILIK</div>
                <div class="satilik">KİRALIK</div>
            </div>

        </div>
        <div id="isyeri_buton">
            <div id="isyeri_icon">
                <div id="icon_isyeri">
                    <a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image2','','images/isyeri_icon2.png',1)">
                        <img src="images/isyeri_icon.png" width="75" height="78" id="Image2" /></a>
                </div>

            </div>

            <div id="isyeri_satilik">
                <div class="satilik_isyeri">SATILIK</div>
                <div class="satilik_isyeri">KİRALIK</div>
                <div class="satilik_isyeri">DEVREN</div>


            </div>

        </div>
        <div id="arsa_buton">
            <div id="arsa_icon">
                <div id="icon_arsa">
                    <a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image3','','images/arsa_icon2.png',1)">
                        <img src="images/arsa_icon.png" width="78" height="80" id="Image3" /></a>
                </div>

            </div>
            <div id="arsa_satilik">
                <div class="satilik_arsa">SATILIK</div>
                <div class="satilik_arsa">KİRALIK</div>
            </div>

        </div>
        <div id="otel_buton">
            <div id="otel_icon">
                <div id="icon_otel">
                    <a href="#" onmouseout="MM_swapImgRestore()" onmouseover="MM_swapImage('Image4','','images/hotel_icon2.png',1)">
                        <img src="images/hotel_icon.png" width="85" height="85" id="Image4" /></a>
                </div>

            </div>
            <div id="otel_satilik">
                <div class="satilik_otel">SATILIK</div>
                <div class="satilik_otel">KİRALIK</div>
                <div class="satilik_otel">DEVREN</div>

            </div>



        </div>

    </div>
    <!--Buton  Alanı bitti-->
    <div id="vitrin_ust"></div>
    <div id="vitrin_baslik">VİTRİN ALANI</div>
    <div id="vitrin">

        <asp:Repeater ID="rpVitrin" runat="server">
            <ItemTemplate>
                <div class="vitrin_ilan">
                    <div class="vitrin_resim">
                      <a href="ilan.aspx?ilanId=<%#Eval("ilanId") %>">  <img border="0"  height="96" width="140" src="ilanResimleri/200/<%#Eval("VitrinResim")%>" /></a>
                    </div>
                    <div class="sat"><%#Eval("islem") %></div>
                    <div class="fiyat"><%#Eval("Fiyat")%> &nbsp;<%#Eval("FiyatTur")%></div>
                    <div class="ilce"><%#Eval("TurAdi")%> </div>
                    <div class="ilce"><%#Eval("ilceadi")%></div>
                    <div class="ilce"><%#Eval("SemtAdi")%></div>

                </div>
            </ItemTemplate>
        </asp:Repeater>








    </div>



    <div style="height: 5px; width: 970px; background-color: #000000;">&nbsp </div>
    <div id="Anasayfa_alt">
        <div id="SonEklenenler">
            <div class="SonEklenenBaslik">Son Eklenen İlanlar</div>


            <asp:Repeater ID="rpSonEklenen" runat="server">
                <ItemTemplate>
                    <div class="SonEklenen">
                        <!--Son Eklenen Başlangıç -->
                        <div class="SonEklenenResim">
                            <img height="90" width="90" src="ilanResimleri/200/<%#Eval("VitrinResim") %>" />
                        </div>
                        <div class="SonEklenenAyrinti">
                            <div class="SonAyrintiSatir"><%#Eval("islem") %></div>
                            <div class="SonAyrintiSatir"><%#Eval("TurAdi") %></div>
                            <div class="SonAyrintiSatir"><%#Eval("ilceAdi") %></div>
                            <div class="SonAyrintiSatir"><%#Eval("Fiyat") %> &nbsp; <%#Eval("FiyatTur") %></div>
                            <div class="SonAyrintiTarih"><%#Eval("Tarih") %></div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>












        </div>
        <div id="AnasayfaReklam">
            <div class="arama_alani">
                <div class="arama_Baslik">İlan Arama Bölümü</div>
                <div class="arama_satir">
                    <div class="arama_sol">İlçeyi Seçebilirsiniz</div>
                    <div class="arama_sag">
                        <asp:DropDownList ID="ddlilce" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="arama_satir">
                            <div class="arama_sol">Türü Seçebilirsiniz</div>
                            <div class="arama_sag">
                                <asp:DropDownList ID="ddlTur" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTur_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>


                        <div class="arama_satir">
                            <div class="arama_sol">Alt Türü Seçebilirsiniz</div>
                            <div class="arama_sag">
                                <asp:DropDownList ID="ddlAltTur" runat="server" Enabled="False"></asp:DropDownList>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>





                <div class="arama_satir">
                    <div class="arama_sol">
                        <asp:LinkButton ID="lbDetay" runat="server">Detaylı Arama</asp:LinkButton>
                    </div>
                    <div class="arama_sag">
                        <asp:Button ID="btnAra" runat="server" Text="Ara" OnClick="btnAra_Click" />
                    </div>
                </div>





            </div>

        </div>
        <div id="AnasayfaHit">
            <div class="SonEklenenBaslik">En Çok Takip Edilen  İlanlar</div>
            <asp:Repeater ID="rpHit" runat="server">
                <ItemTemplate>
                    <div class="Hit">

                        <div class="SonEklenenResim">
                            <img height="90" width="90" src="ilanResimleri/200//<%#Eval("VitrinResim") %>" />
                        </div>
                        <div class="HitAyrinti">
                            <div class="HitAyrintiSatir"><%#Eval("islem") %></div>
                            <div class="HitAyrintiSatir"><%#Eval("TurAdi") %></div>
                            <div class="HitAyrintiSatir"><%#Eval("ilceAdi") %></div>
                            <div class="HitAyrintiSatir"><%#Eval("Fiyat") %> &nbsp; <%#Eval("FiyatTur") %></div>
                            <div class="HitAyrintiHit"><%#Eval("Hit") %></div>
                            <div class="SonAyrintiTarih"><%#Eval("Tarih") %></div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>







        </div>
        <div class="temizle"></div>
    </div>
</asp:Content>

