<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ilan.aspx.cs" Inherits="ilan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <!-- Insert to your webpage before the </head> -->
    <script src="slider_JS/jquery.js"></script>
    <script src="slider_JS/amazingslider.js"></script>
    <link rel="stylesheet" type="text/css" href="slider_JS/amazingslider-1.css">
    <script src="slider_JS/initslider-1.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="float: left; width: 550px; height: auto;">


        <!-- Insert to your webpage where you want to display the slider -->
        <div id="amazingslider-wrapper-1" style="display: block; position: relative; max-width: 520px; margin: 0px auto 102px;">
            <div id="amazingslider-1" style="display: block; position: relative; margin: 0 auto;">
                <ul class="amazingslider-slides" style="display: none;">
                    <li>
                        <asp:Image ID="imgVitrin" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img1" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img2" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img3" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img4" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img5" runat="server" /></li>
                </ul>
                <ul class="amazingslider-thumbnails" style="display: none;">
                    <li>
                        <asp:Image ID="imgVitrin1" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img1_1" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img2_2" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img3_3" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img4_4" runat="server" /></li>
                    <li>
                        <asp:Image ID="Img5_5" runat="server" /></li>

                </ul>

            </div>
        </div>

        <!-- End of body section HTML codes -->
    </div>


    <div id="ilan_detay_ozellik">
        <asp:Repeater ID="rpilanGenel" runat="server">
            <ItemTemplate>
                <div class="ilan_detay_fiyat"><%#Eval("Fiyat") %> <%#Eval("FiyatTur") %></div>
                <div class="ilan_detay_semt"><%#Eval("ilceAdi") %>&nbsp;/&nbsp;<%#Eval("SemtAdi") %>&nbsp;/&nbsp;<%#Eval("MahalleAdi") %></div>

                <div class="ilan_detay_oz_sol">İlan Tarihi</div>
                <div class="ilan_detay_oz_sag"><%#Eval("Tarih") %></div>


                <div class="ilan_detay_oz_sol">Kimden</div>
                <div class="ilan_detay_oz_sag"><%#Eval("Kimden") %></div>


                <div class="ilan_detay_oz_sol">İlan Türü</div>
                <div class="ilan_detay_oz_sag"><%#Eval("AltTurAdi") %></div>


                <div class="ilan_detay_oz_sol">islem</div>
                <div class="ilan_detay_oz_sag"><%#Eval("islem") %></div>

            </ItemTemplate>
        </asp:Repeater>


        <asp:Panel ID="pnlArsa" Visible="false" runat="server">
            <asp:Repeater ID="rpArsaGenel" runat="server">
                <ItemTemplate>

                    <div class="ilan_detay_oz_sol">Metre:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Metre") %> </div>


                    <div class="ilan_detay_oz_sol">İmar Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("imarDurumu") %> </div>



                    <div class="ilan_detay_oz_sol">AdaNo:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("AdaNo") %> </div>



                    <div class="ilan_detay_oz_sol">ParselNo:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("ParselNo") %> </div>



                    <div class="ilan_detay_oz_sol">PaftaNo:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("PaftaNo") %> </div>


                    <div class="ilan_detay_oz_sol">Kaks:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Kaks") %> </div>



                    <div class="ilan_detay_oz_sol">Gabari:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Gabari") %> </div>


                    <div class="ilan_detay_oz_sol">Tapu Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Tapu") %> </div>



                    <div class="ilan_detay_oz_sol">Kat Karşılığı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("KatKarsiligi") %> </div>

                    <div class="ilan_detay_oz_sol">Kredi Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Kredi") %> </div>

                </ItemTemplate>
            </asp:Repeater>


        </asp:Panel>


        <asp:Panel ID="pnlKonutGenel" Visible="false" runat="server">
            <asp:Repeater ID="rpKonutGenel" runat="server">
                <ItemTemplate>
                    <div class="ilan_detay_oz_sol">Metre:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Metre") %> </div>


                    <div class="ilan_detay_oz_sol">Oda Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("OdaSayisi") %> </div>



                    <div class="ilan_detay_oz_sol">Banyo Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BanyoSayisi") %> </div>



                    <div class="ilan_detay_oz_sol">Bina Yaşı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BinaYasi") %> </div>



                    <div class="ilan_detay_oz_sol">Binadaki Kat:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BinadakiKat") %> </div>



                    <div class="ilan_detay_oz_sol">Bulunduğu Kat:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BulunduguKat") %> </div>



                    <div class="ilan_detay_oz_sol">Isıtma Türü:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("IsitmaTur") %> </div>



                    <div class="ilan_detay_oz_sol">Kredi Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Kredi") %> </div>



                    <div class="ilan_detay_oz_sol">Yapı Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Durum") %> </div>



                </ItemTemplate>
            </asp:Repeater>
        </asp:Panel>

        <asp:Panel ID="pnlDevreGenel" Visible="false" runat="server">

            <asp:Repeater ID="rpDevreGenel" runat="server">
                <ItemTemplate>
                    <div class="ilan_detay_oz_sol">Dönem:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Donem") %> </div>


                    <div class="ilan_detay_oz_sol">Süre:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Sure") %> </div>



                    <div class="ilan_detay_oz_sol">Oda Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Oda") %> </div>

                </ItemTemplate>
            </asp:Repeater>


        </asp:Panel>


        <asp:Panel ID="pnlBinaGenel" Visible="false" runat="server">

            <asp:Repeater ID="rpBinaGenel" runat="server">
                <ItemTemplate>
                    <div class="ilan_detay_oz_sol">Kat Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("KatSayisi") %> </div>


                    <div class="ilan_detay_oz_sol">Kattaki Daire:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("KattakiDaire") %> </div>



                    <div class="ilan_detay_oz_sol">Isıtma Türü:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("IsitmaTur") %> </div>


                    <div class="ilan_detay_oz_sol">Metre:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Metre") %> </div>


                    <div class="ilan_detay_oz_sol">Bina Yaşı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BinaYasi") %> </div>

                </ItemTemplate>
            </asp:Repeater>


        </asp:Panel>




        <asp:Panel ID="pnlTesisGenel" Visible="false" runat="server">

            <asp:Repeater ID="rpTesisGenel" runat="server">
                <ItemTemplate>
                    <div class="ilan_detay_oz_sol">Yıldız:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Yildiz") %> </div>


                    <div class="ilan_detay_oz_sol">Oda Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("OdaSayisi") %> </div>



                    <div class="ilan_detay_oz_sol">Kat Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("KatSayisi") %> </div>


                    <div class="ilan_detay_oz_sol">Bina Yaşı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("BinaYasi") %> </div>


                    <div class="ilan_detay_oz_sol">Açık Alan:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("AcikAlan") %> </div>


                    <div class="ilan_detay_oz_sol">Kapalı Alan:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("KapaliAlan") %> </div>



                    <div class="ilan_detay_oz_sol">Zemin Edutu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("ZeminEtudu") %> </div>


                    <div class="ilan_detay_oz_sol">Kredi Durumu:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("Kredi") %> </div>


                    <div class="ilan_detay_oz_sol">Apart Sayısı:</div>
                    <div class="ilan_detay_oz_sag"><%#Eval("ApartSayisi") %> </div>




                </ItemTemplate>
            </asp:Repeater>


        </asp:Panel>





    </div>

    <div id="ilan_detay_kul">
        Mehmet Yıldız 
    </div>
    <div class="temizle"></div>

    <div id="ilan_detay_gozellik">
        <p>İlan Detay Özellikleri</p>
        <asp:Literal ID="ltrlAciklama" runat="server"></asp:Literal>
    </div>




    <asp:Panel ID="pnlAltYapi" Visible="false" runat="server">

        <div class="ilan_coklu_ozellik">
            <p>Alt Yapı Özellikleri</p>

            <asp:Repeater ID="rpAltYapi" runat="server">
                <ItemTemplate>
                    <div class="ilan_secenek">
                        <img src="images/thk.png" />&nbsp;<%#Eval("AltYapi") %></div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </asp:Panel>



    <div class="temizle"></div>



    <asp:Panel ID="pnlMuhit" Visible="false" runat="server">

        <div class="ilan_coklu_ozellik">
            <p>Muhit Özellikleri</p>

            <asp:Repeater ID="rpMuhit" runat="server">
                <ItemTemplate>
                    <div class="ilan_secenek">
                        <img src="images/thk.png" />&nbsp;<%#Eval("Muhit") %></div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </asp:Panel>





</asp:Content>

