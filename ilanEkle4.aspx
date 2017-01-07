<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ilanEkle4.aspx.cs" Inherits="ilanEkle4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Panel ID="pnl_vitrin_a" runat="server">
        <div class="resim_baslik">Vitrin Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuVitrin" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btnVitrin" runat="server" Text="Yükle" OnClick="btnVitrin_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_vitrin_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">Vitrin Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgVitrin" runat="server" />
        </div>
    </asp:Panel>

    <!-- Bitişşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşş-->
    <asp:Panel Visible="False" ID="pnl_res2_a" runat="server">
        <div class="temizle"></div>
        <div class="resim_baslik">2. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuiki" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btniki" runat="server" Text="Yükle" OnClick="btniki_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_res2_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">2. Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgRes2" runat="server" />
        </div>
    </asp:Panel>

    <!-- Bitişşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşş-->
    <asp:Panel Visible="False" ID="pnl_res3_a" runat="server">
        <div class="temizle"></div>
        <div class="resim_baslik">3. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuuc" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btnuc" runat="server" Text="Yükle" OnClick="btnuc_Click" style="height: 26px" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_res3_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">3. Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgRes3" runat="server" />
        </div>
    </asp:Panel>


    <!-- Bitişşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşş-->
    <asp:Panel Visible="False" ID="pnl_res4_a" runat="server">
        <div class="temizle"></div>
        <div class="resim_baslik">4. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuDort" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btnDort" runat="server" Text="Yükle" OnClick="btnDort_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_res4_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">4. Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgRes4" runat="server" />
        </div>
    </asp:Panel>


    <!-- Bitişşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşş-->
    <asp:Panel Visible="False" ID="pnl_res5_a" runat="server">
        <div class="temizle"></div>
        <div class="resim_baslik">5. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuBes" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btnBes" runat="server" Text="Yükle" OnClick="btnBes_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_res5_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">5. Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgRes5" runat="server" />
        </div>
    </asp:Panel>



    <!-- Bitişşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşşş-->
    <asp:Panel Visible="False" ID="pnl_res6_a" runat="server">
        <div class="temizle"></div>
        <div class="resim_baslik">6. Resminizi Yükleyin</div>
        <div>
            <asp:FileUpload ID="fuAlti" runat="server" />
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="btnAlti" runat="server" Text="Yükle" OnClick="btnAlti_Click" />
        </div>

    </asp:Panel>

    <asp:Panel ID="pnl_res6_b" runat="server" Visible="False">
        <div class="resim_sola">
            <div class="Resim_baslik_2">6. Resminiz</div>
            <asp:Image Width="90px" Height="115px" ID="imgRes6" runat="server" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pnl_son" runat="server">
        <div class="temizle"></div>
        <div style="font-family: 'Trebuchet MS'; font-size: 13px; font-weight: bold; color: #666666"> İşleminizi Tamamlamak için aşağıdaki butona Tıklayınız!! </div>
       <div style="padding-top: 10px;  text-align: center; margin-top: 10px; padding-bottom: 15px;"> <asp:Button CssClass="myButton" ID="btnDevam" runat="server" Text="Devam" OnClick="btnDevam_Click" /></div>
    </asp:Panel>

</asp:Content>

