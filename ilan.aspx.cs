using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilan : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilanId = ""; string Tur = ""; string AltTur = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ilanId = Request.QueryString["ilanId"];

        DataRow drilan = klas.GetDataRow("Select * From ilanResimler Where ilanId=" + ilanId);
        DataRow drilanAciklama = klas.GetDataRow("Select Aciklama From ilanlar Where ilanId=" + ilanId);
        ltrlAciklama.Text = drilanAciklama["Aciklama"].ToString();


        DataRow drTur = klas.GetDataRow("SELECT  dbo.ilanlar.*, dbo.AltTurler.AltTurAdi, dbo.Turler.TurAdi" +
                         " FROM  dbo.ilanlar INNER JOIN" +
                         " dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN" +
                         " dbo.AltTurler ON dbo.ilanlar.AltTurId = dbo.AltTurler.AltTurId WHERE dbo.ilanlar.ilanId=" + ilanId);
        Tur = drTur["TurAdi"].ToString();
        AltTur = drTur["AltTurAdi"].ToString();

        if (Tur == "Arsa")
        {
            pnlArsa.Visible = true;
            ArsaGenel();
            pnlAltYapi.Visible = true; AltYapi();
        }

        if (Tur == "Konut" || Tur== "İşyeri (Satılık)" || Tur== "İşyeri (Devren)")
        {
            if (AltTur == "Residence")
            {

                pnlKonutGenel.Visible = true;
                KonutGenel();
            }

            else
            {
                pnlKonutGenel.Visible = true;
                KonutGenel();

            }
        }

        if(Tur=="Devremülk")
        {
            pnlDevreGenel.Visible = true;
            DevreGenel();
        }

        if(Tur=="Bina")
        {
            pnlBinaGenel.Visible = true;
            BinaGenel();
        }

        if(Tur=="Turistik Tesis")
        {
            pnlTesisGenel.Visible = true;
            TesisGenel();

        }


        if (drilan["VitrinResim"].ToString() != null)
        {
            imgVitrin.ImageUrl = "ilanResimleri/700/" + drilan["VitrinResim"].ToString();
            imgVitrin1.ImageUrl = "ilanResimleri/200/" + drilan["VitrinResim"].ToString();
        }

        if (drilan["Resim2"].ToString() != null)
        {
            Img1.ImageUrl = "ilanResimleri/700/" + drilan["Resim2"].ToString();
            Img1_1.ImageUrl = "ilanResimleri/200/" + drilan["Resim2"].ToString();
        }
        if (drilan["Resim3"].ToString() != null)
        {
            Img2.ImageUrl = "ilanResimleri/700/" + drilan["Resim3"].ToString();
            Img2_2.ImageUrl = "ilanResimleri/200/" + drilan["Resim3"].ToString();
        }
        if (drilan["Resim4"].ToString() != null)
        {
            Img3.ImageUrl = "ilanResimleri/700/" + drilan["Resim4"].ToString();
            Img3_3.ImageUrl = "ilanResimleri/200/" + drilan["Resim4"].ToString();
        }
        if (drilan["Resim5"].ToString() != null)
        {
            Img4.ImageUrl = "ilanResimleri/700/" + drilan["Resim5"].ToString();
            Img4_4.ImageUrl = "ilanResimleri/200/" + drilan["Resim5"].ToString();
        }
        if (drilan["Resim6"].ToString() != null)
        {
            Img5.ImageUrl = "ilanResimleri/700/" + drilan["Resim6"].ToString();
            Img5_5.ImageUrl = "ilanResimleri/200/" + drilan["Resim6"].ToString();
        }

        DataTable dtilanGenel = klas.GetDataTable("SELECT  dbo.ilanlar.*, dbo.FiyatTurler.FiyatTur, dbo.mahalle.MahalleAdi, dbo.islemler.islem, dbo.ilceler.ilceAdi, dbo.Kimden.Kimden, dbo.semt.SemtAdi, dbo.AltTurler.AltTurAdi" +
                         " FROM   dbo.ilanlar INNER JOIN" +
                         " dbo.FiyatTurler ON dbo.ilanlar.FiyatTurId = dbo.FiyatTurler.FiyatTurId INNER JOIN" +
                         " dbo.ilceler ON dbo.ilanlar.ilceId = dbo.ilceler.ilceId INNER JOIN" +
                         " dbo.mahalle ON dbo.ilanlar.MahalleId = dbo.mahalle.MahalleId INNER JOIN" +
                         " dbo.semt ON dbo.ilanlar.SemtId = dbo.semt.SemtId INNER JOIN" +
                         " dbo.Kimden ON dbo.ilanlar.KimdenId = dbo.Kimden.KimdenId INNER JOIN" +
                         " dbo.AltTurler ON dbo.ilanlar.AltTurId = dbo.AltTurler.AltTurId INNER JOIN" +
                         " dbo.islemler ON dbo.ilanlar.islemId = dbo.islemler.islemId Where dbo.ilanlar.ilanId=" + ilanId);
        rpilanGenel.DataSource = dtilanGenel;
        rpilanGenel.DataBind();

    }



    void ArsaGenel()
    {
        DataTable dtArsaGenel = klas.GetDataTable("SELECT   dbo.ArsaOzellikler.*, dbo.imarDurumu.imarDurumu, dbo.Kaks.Kaks, dbo.Gabari.Gabari, dbo.TapuDurumu.Tapu, dbo.Kredi.Kredi, dbo.KatKarsiligi.KatKarsiligi" +
                         " FROM   dbo.ArsaOzellikler INNER JOIN" +
                         " dbo.imarDurumu ON dbo.ArsaOzellikler.imarDurumuId = dbo.imarDurumu.imarDurumuId INNER JOIN" +
                         " dbo.Kaks ON dbo.ArsaOzellikler.KaksId = dbo.Kaks.KaksId INNER JOIN" +
                         " dbo.Gabari ON dbo.ArsaOzellikler.GabariId = dbo.Gabari.GabariId INNER JOIN" +
                         " dbo.TapuDurumu ON dbo.ArsaOzellikler.TapuDurumuId = dbo.TapuDurumu.TapuDurumuId INNER JOIN" +
                         " dbo.Kredi ON dbo.ArsaOzellikler.KrediId = dbo.Kredi.KrediId INNER JOIN" +
                         " dbo.KatKarsiligi ON dbo.ArsaOzellikler.KatKarsiligiId = dbo.KatKarsiligi.KatKarsiligiId WHERE dbo.ArsaOzellikler.ilanId=" + ilanId);
        rpArsaGenel.DataSource = dtArsaGenel;
        rpArsaGenel.DataBind();
    }



    void KonutGenel()
    {
        DataTable dtKonutGenel = klas.GetDataTable("SELECT  dbo.YapiDurumu.Durum, dbo.Kredi.Kredi, dbo.IsitmaTurler.IsitmaTur, dbo.KonutOzellikler.*, dbo.OdaSayisi.OdaSayisi, dbo.BanyoSayisi.BanyoSayisi, dbo.BinaYasi.BinaYasi" +
                         " FROM  dbo.KonutOzellikler INNER JOIN" +
                         " dbo.OdaSayisi ON dbo.KonutOzellikler.OdaId = dbo.OdaSayisi.OdaId INNER JOIN" +
                         " dbo.BanyoSayisi ON dbo.KonutOzellikler.BanyoId = dbo.BanyoSayisi.BanyoId INNER JOIN" +
                         " dbo.BinaYasi ON dbo.KonutOzellikler.BinaYasId = dbo.BinaYasi.BinaYasId INNER JOIN" +
                         " dbo.IsitmaTurler ON dbo.KonutOzellikler.IsitmaTurId = dbo.IsitmaTurler.IsitmaTurId INNER JOIN" +
                         " dbo.Kredi ON dbo.KonutOzellikler.KrediId = dbo.Kredi.KrediId INNER JOIN" +
                         " dbo.YapiDurumu ON dbo.KonutOzellikler.DurumId = dbo.YapiDurumu.DurumId WHERE dbo.KonutOzellikler.ilanId=" + ilanId);
        rpKonutGenel.DataSource = dtKonutGenel;
        rpKonutGenel.DataBind();
    }


    void DevreGenel()
    {
        DataTable dtDevreGenel = klas.GetDataTable(" SELECT dbo.DevreOzellik.*, dbo.Donem.Donem, dbo.Sure.Sure" +
                         " FROM   dbo.DevreOzellik INNER JOIN" +
                         " dbo.Donem ON dbo.DevreOzellik.DonemId = dbo.Donem.DonemId INNER JOIN" +
                         " dbo.Sure ON dbo.DevreOzellik.SureId = dbo.Sure.SureId WHERE dbo.DevreOzellik.ilanId=" + ilanId);
        rpDevreGenel.DataSource = dtDevreGenel;
        rpDevreGenel.DataBind();
    }


    void BinaGenel()
    {
        DataTable dtBinaGenel = klas.GetDataTable("SELECT  dbo.BinaOzellikler.*, dbo.IsitmaTurler.IsitmaTur, dbo.BinaYasi.BinaYasi"+
                         " FROM   dbo.BinaOzellikler INNER JOIN"+
                         " dbo.IsitmaTurler ON dbo.BinaOzellikler.IsitmaTurId = dbo.IsitmaTurler.IsitmaTurId INNER JOIN"+
                         " dbo.BinaYasi ON dbo.BinaOzellikler.BinaYasId = dbo.BinaYasi.BinaYasId Where BinaOzellikler.ilanId=" + ilanId);
        rpBinaGenel.DataSource = dtBinaGenel;
        rpBinaGenel.DataBind();
    }


    void TesisGenel()
    {
        DataTable dtTesisGenel = klas.GetDataTable("SELECT dbo.TesisOzellik.*, dbo.Yildiz.Yildiz, dbo.BinaYasi.BinaYasi, dbo.Kredi.Kredi"+
                         " FROM  dbo.TesisOzellik INNER JOIN"+
                         " dbo.Yildiz ON dbo.TesisOzellik.YildizId = dbo.Yildiz.YildizId INNER JOIN"+
                         " dbo.BinaYasi ON dbo.TesisOzellik.BinaYasId = dbo.BinaYasi.BinaYasId INNER JOIN"+
                         " dbo.Kredi ON dbo.TesisOzellik.KrediId = dbo.Kredi.KrediId Where TesisOzellik.ilanId=" + ilanId);
        rpTesisGenel.DataSource = dtTesisGenel;
        rpTesisGenel.DataBind();
    }


    /***********************************Seçililer***************************************************************/
    void AltYapi()
    {
        DataTable dtAltYapi = klas.GetDataTable("SELECT  dbo.SeciliAltYapi.*, dbo.AltYapi.AltYapi"+
                         " FROM  dbo.SeciliAltYapi INNER JOIN"+
                         " dbo.AltYapi ON dbo.SeciliAltYapi.AltYapiId = dbo.AltYapi.AltYapiId Where dbo.SeciliAltYapi.ilanId="+ilanId);
        rpAltYapi.DataSource = dtAltYapi;
        rpAltYapi.DataBind();
    }


    void Muhit()
    {
        DataTable dtMuhit = klas.GetDataTable("SELECT  dbo.SeciliMuhit.*, dbo.Muhit.Muhit"+
                         " FROM  dbo.SeciliMuhit INNER JOIN"+
                         " dbo.Muhit ON dbo.SeciliMuhit.MuhitId = dbo.Muhit.MuhitId Where dbo.SeciliMuhit.ilanId=" + ilanId);
        rpMuhit.DataSource = dtMuhit;
        rpMuhit.DataBind();
    }

}