<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle.aspx.cs" Inherits="ilanEkle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="ilan_hata">
                <asp:Literal ID="ltrlHata" runat="server"></asp:Literal>

            </div>
            <div class="satir1">İlanın Türü:</div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlilanTur" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlilanTur_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->

            <div class="satir1">İlanın Alt Tür: </div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlilanAltTur" runat="server" Enabled="False">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->
        </ContentTemplate>
    </asp:UpdatePanel>




    <div class="satir1">İlan Başlığınız:</div>
    <div class="satir2" style="text-align: left">
        <asp:TextBox ID="txtBaslik" runat="server" Width="250px"></asp:TextBox>
        <asp:TextBoxWatermarkExtender TargetControlID="txtBaslik" WatermarkText="Lütfen ilan Başlığını Giriniz" WatermarkCssClass="water" ID="TextBoxWatermarkExtender1" runat="server"></asp:TextBoxWatermarkExtender>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->



    <div class="satir1">İşleminiz:</div>
    <div class="satir2" style="text-align: left">
        <asp:DropDownList ID="ddlislem" runat="server">
        </asp:DropDownList>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1">Fiyat Türünüz:</div>
    <div class="satir2" style="text-align: left">
        <asp:DropDownList ID="ddlFiyatTur" runat="server">
        </asp:DropDownList>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1">Fiyatınız:</div>
    <div class="satir2" style="text-align: left">
        <asp:TextBox ID="txtFiyat" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender TargetControlID="txtFiyat" FilterType="Numbers" ID="FilteredTextBoxExtender1" runat="server"></asp:FilteredTextBoxExtender>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1">Kimden:</div>
    <div class="satir2" style="text-align: left">
        <asp:DropDownList ID="ddlKimden" runat="server">
        </asp:DropDownList>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>



            <div class="satir1">İli Seçin:</div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlil" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlil_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->

            <div class="satir1">İlçeyi Seçin:</div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlilce" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlilce_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->

            <div class="satir1">Semti Seçin:</div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlSemt" runat="server" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlSemt_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->

            <div class="satir1">Mahalleyi Seçin:</div>
            <div class="satir2" style="text-align: left">
                <asp:DropDownList ID="ddlMahalle" runat="server" Enabled="False">
                </asp:DropDownList>
            </div>
            <div class="satir3"></div>
            <div class="temizle"></div>
            <!--Satırlar Bitti-->
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="satir1">Takaslı Mı ?</div>
    <div class="satir2" style="text-align: left">
        <asp:RadioButton ID="rdTakasEvet" runat="server" Text="Evet" GroupName="Takas" />
        <asp:RadioButton ID="rdTakasHayir" runat="server" Text="Hayır" Checked="True" GroupName="Takas" />
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1">Açıklama:</div>
    <div class="satir4" style="text-align: left">
        <asp:TextBox ID="txtAciklama" runat="server" TextMode="MultiLine" Width="280px" Height="80px"></asp:TextBox>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1">Açık Adres:</div>
    <div class="satir4" style="text-align: left">
        <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine" Width="280px" Height="80px"></asp:TextBox>
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->

    <div class="satir1"></div>
    <div class="satir2" style="text-align: left">
        <asp:Button ID="btnKaydet" runat="server" Text="İlanı Kaydet" OnClick="btnKaydet_Click" />
    </div>
    <div class="satir3"></div>
    <div class="temizle"></div>
    <!--Satırlar Bitti-->


</asp:Content>

