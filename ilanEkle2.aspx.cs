using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilanEkle2 : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilanId = ""; string ilanTurId = ""; string ArsaTurId = ""; string BinaTurId = ""; string DevreTurId = "";
    string KonutTurId = ""; string isyeriDevrenTurId = ""; string isyeriSatilikTurId = ""; string TuristikTurId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            imarDurumu();
            Kaks();
            Gabari();
            Tapu();
            Kredi();
            BinaYasi();
            Binaisitma();
            DevreDonemi();
            DevreSuresi();
            Konutisitma();
            KonutOdaSayisi();
            KonutBinaYasi();
            KonutBanyoSayisi();
            KonutKrediDurumu();
            KonutBinaDurumu();
            TuristYildizSayisi();
            TuristBinaYasi();
            TuristKrediDurumu();
        }
        if (Session["KullaniciId"] == null)
            Response.Redirect("GirisYap.aspx");
        DataRow drilan = klas.GetDataRow("Select TOP 1 ilanId From ilanlar Where KullaniciId=" + Session["KullaniciId"] + " order by [ilanId] desc");
        ilanId = drilan["ilanId"].ToString();

        ilanTurId = klas.GetDataCell("Select TurId From ilanlar Where ilanId=" + ilanId);

        DataRow drArsa = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "Arsa" + "'");
        ArsaTurId = drArsa["TurId"].ToString();

        DataRow drBina = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "Bina" + "'");
        BinaTurId = drBina["TurId"].ToString();

        DataRow drDevre = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "Devremülk" + "'");
        DevreTurId = drDevre["TurId"].ToString();

        DataRow drKonut = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "Konut" + "'");
        KonutTurId = drKonut["TurId"].ToString();

        DataRow drisyeriDevren = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "İşyeri (Devren)" + "'");
        isyeriDevrenTurId = drisyeriDevren["TurId"].ToString();

        DataRow drisyeriSatilik = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "İşyeri (Satılık)" + "'");
        isyeriSatilikTurId = drisyeriSatilik["TurId"].ToString();

        DataRow drTuristik = klas.GetDataRow("Select TurId From Turler Where TurAdi='" + "Turistik Tesis" + "'");
        TuristikTurId = drTuristik["TurId"].ToString();





        if (ilanTurId == ArsaTurId)
            pnlArsa.Visible = true;


        if (ilanTurId == BinaTurId)
            pnlBina.Visible = true;

        if (ilanTurId == DevreTurId)
            pnlDevre.Visible = true;

        if (ilanTurId == KonutTurId || ilanTurId == isyeriDevrenTurId || ilanTurId == isyeriSatilikTurId)
            pnlKonut.Visible = true;

        if (ilanTurId == TuristikTurId)
            pnlTuristik.Visible = true;




    }


    /// <summary>
    /// ///////////////////////////Turistik Tesis  Başladı///////////////////////////////////////////////////////////////////
    /// </summary>
    void TuristYildizSayisi()
    {
        DataTable dtTuristYildizSayisi = klas.GetDataTable("Select * From Yildiz");
        ddlTuristYildiz.DataTextField = "Yildiz";
        ddlTuristYildiz.DataValueField = "YildizId";
        ddlTuristYildiz.DataSource = dtTuristYildizSayisi;
        ddlTuristYildiz.DataBind();
    }

    void TuristBinaYasi()
    {
        DataTable dtTuristBinaYasi = klas.GetDataTable("Select * From BinaYasi");
        ddlTuristBinaYasi.DataTextField = "BinaYasi";
        ddlTuristBinaYasi.DataValueField = "BinaYasId";
        ddlTuristBinaYasi.DataSource = dtTuristBinaYasi;
        ddlTuristBinaYasi.DataBind();
    }

    void TuristKrediDurumu()
    {
        DataTable dtTuristKrediDurumu = klas.GetDataTable("Select * From Kredi");
        ddlTuristKredi.DataTextField = "Kredi";
        ddlTuristKredi.DataValueField = "KrediId";
        ddlTuristKredi.DataSource = dtTuristKrediDurumu;
        ddlTuristKredi.DataBind();
    }




    /// <summary>
    /// ///////////////////////////Konut  Başladı///////////////////////////////////////////////////////////////////
    /// </summary>
    /// 

    void KonutBinaDurumu()
    {
        DataTable dtKonutBinaDurumu = klas.GetDataTable("Select * From BinaYasi");
        ddlKonutBinaDurumu.DataTextField = "BinaYasi";
        ddlKonutBinaDurumu.DataValueField = "BinaYasId";
        ddlKonutBinaDurumu.DataSource = dtKonutBinaDurumu;
        ddlKonutBinaDurumu.DataBind();
    }

    void KonutKrediDurumu()
    {
        DataTable dtKonutKrediDurumu = klas.GetDataTable("Select * From Kredi");
        ddlKonutKredi.DataTextField = "Kredi";
        ddlKonutKredi.DataValueField = "KrediId";
        ddlKonutKredi.DataSource = dtKonutKrediDurumu;
        ddlKonutKredi.DataBind();
    }


    void KonutBanyoSayisi()
    {
        DataTable dtKonutBanyoSayisi = klas.GetDataTable("Select * From BanyoSayisi");
        ddlKonutBanyoSayisi.DataTextField = "BanyoSayisi";
        ddlKonutBanyoSayisi.DataValueField = "BanyoId";
        ddlKonutBanyoSayisi.DataSource = dtKonutBanyoSayisi;
        ddlKonutBanyoSayisi.DataBind();
    }



    void KonutBinaYasi()
    {
        DataTable dtKonutBinaYasi = klas.GetDataTable("Select * From BinaYasi");
        ddlKonutBinaYasi.DataTextField = "BinaYasi";
        ddlKonutBinaYasi.DataValueField = "BinaYasId";
        ddlKonutBinaYasi.DataSource = dtKonutBinaYasi;
        ddlKonutBinaYasi.DataBind();
    }


    void KonutOdaSayisi()
    {
        DataTable dtKonutOdaSayisi = klas.GetDataTable("Select * From OdaSayisi");
        ddlKonutOdasayisi.DataTextField = "OdaSayisi";
        ddlKonutOdasayisi.DataValueField = "OdaId";
        ddlKonutOdasayisi.DataSource = dtKonutOdaSayisi;
        ddlKonutOdasayisi.DataBind();
    }


    void Konutisitma()
    {
        DataTable dtisitmaTurKonut = klas.GetDataTable("Select * From IsitmaTurler");
        ddlisitma_Konut.DataTextField = "IsitmaTur";
        ddlisitma_Konut.DataValueField = "IsitmaTurId";
        ddlisitma_Konut.DataSource = dtisitmaTurKonut;
        ddlisitma_Konut.DataBind();
    }




    /// <summary>
    /// ///////////////////////////Devre Mülk Başladı///////////////////////////////////////////////////////////////////
    /// </summary>


    void DevreDonemi()
    {
        DataTable dtDevreDonemi = klas.GetDataTable("Select * From Donem");
        ddlDevreDonem.DataTextField = "Donem";
        ddlDevreDonem.DataValueField = "DonemId";
        ddlDevreDonem.DataSource = dtDevreDonemi;
        ddlDevreDonem.DataBind();
    }


    void DevreSuresi()
    {
        DataTable dtDevreSuresi = klas.GetDataTable("Select * From Sure");
        ddlDevreSure.DataTextField = "Sure";
        ddlDevreSure.DataValueField = "SureId";
        ddlDevreSure.DataSource = dtDevreSuresi;
        ddlDevreSure.DataBind();
    }





    /// <summary>
    /// /////////////////////////////////Bina Başladı////////////////////////////////////////////////////////////////////////
    /// </summary>

    void BinaYasi()
    {
        DataTable dtBinaYasi = klas.GetDataTable("Select * From BinaYasi");
        ddlBinaYasi.DataTextField = "BinaYasi";
        ddlBinaYasi.DataValueField = "BinaYasId";
        ddlBinaYasi.DataSource = dtBinaYasi;
        ddlBinaYasi.DataBind();
    }


    void Binaisitma()
    {
        DataTable dtBinaisitma = klas.GetDataTable("Select * From IsitmaTurler");
        ddlisitma_Bina.DataTextField = "IsitmaTur";
        ddlisitma_Bina.DataValueField = "IsitmaTurId";
        ddlisitma_Bina.DataSource = dtBinaisitma;
        ddlisitma_Bina.DataBind();
    }

    /// <summary>
    /// /////////////////////////////////////Arsa Başladı////////////////////////////////////////////////////////////////////////
    /// </summary>

    void Kredi()
    {
        DataTable dtKredi = klas.GetDataTable("Select * From Kredi");
        ddlKredi.DataTextField = "Kredi";
        ddlKredi.DataValueField = "KrediId";
        ddlKredi.DataSource = dtKredi;
        ddlKredi.DataBind();
    }

    void Tapu()
    {
        DataTable dtTapu = klas.GetDataTable("Select * From TapuDurumu");
        ddlTapu.DataTextField = "Tapu";
        ddlTapu.DataValueField = "TapuDurumuId";
        ddlTapu.DataSource = dtTapu;
        ddlTapu.DataBind();
    }

    void Gabari()
    {
        DataTable dtGabari = klas.GetDataTable("Select * From Gabari");
        ddlGabari.DataTextField = "Gabari";
        ddlGabari.DataValueField = "GabariId";
        ddlGabari.DataSource = dtGabari;
        ddlGabari.DataBind();
    }

    void Kaks()
    {
        DataTable dtKaks = klas.GetDataTable("Select * From Kaks");
        ddlKaks.DataTextField = "Kaks";
        ddlKaks.DataValueField = "KaksId";
        ddlKaks.DataSource = dtKaks;
        ddlKaks.DataBind();
    }

    void imarDurumu()
    {
        DataTable dtimar = klas.GetDataTable("Select * From imarDurumu");
        ddlimarDurumu.DataTextField = "imarDurumu";
        ddlimarDurumu.DataValueField = "imarDurumuId";
        ddlimarDurumu.DataSource = dtimar;
        ddlimarDurumu.DataBind();
    }


    protected void btnArsaKaydet_Click(object sender, EventArgs e)
    {
        string Kat = "";
        if (rdEvet.Checked == true)
        {
            Kat = "1";
        }
        else
        {
            Kat = "0";
        }

        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into ArsaOzellikler(ilanId,imarDurumuId,KaksId,GabariId,TapuDurumuId,KrediId,Metre,Adano,Parselno,Paftano,KatKarsiligi) Values(@ilanId,@imarDurumuId,@KaksId,@GabariId,@TapuDurumuId,@KrediId,@Metre,@Adano,@Parselno,@Paftano,@KatKarsiligi) ", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);

        cmd.Parameters.Add("imarDurumuId", ddlimarDurumu.SelectedValue);

        cmd.Parameters.Add("KaksId", ddlKaks.SelectedValue);

        cmd.Parameters.Add("GabariId", ddlGabari.SelectedValue);

        cmd.Parameters.Add("TapuDurumuId", ddlGabari.SelectedValue);

        cmd.Parameters.Add("KrediId", ddlKredi.SelectedValue);

        cmd.Parameters.Add("Metre", txtMetre_Arsa.Text);

        cmd.Parameters.Add("Adano", txtAda.Text);

        cmd.Parameters.Add("Parselno", txtParsel.Text);

        cmd.Parameters.Add("Paftano", txtPafta.Text);

        cmd.Parameters.Add("KatKarsiligi", Kat);

        cmd.ExecuteNonQuery();

        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);

    }

    protected void btnBinaKaydet_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into BinaOzellikler(ilanId,KatSayisi,KattakiDaire,IsitmaTurId,Metre,BinaYasId) Values(@ilanId,@KatSayisi,@KattakiDaire,@IsitmaTurId,@Metre,@BinaYasId)", baglanti);

        cmd.Parameters.Add("ilanId", ilanId);

        cmd.Parameters.Add("KatSayisi", txtKatSayisi.Text);

        cmd.Parameters.Add("KattakiDaire", txtKattakiDaire.Text);

        cmd.Parameters.Add("IsitmaTurId", ddlisitma_Bina.SelectedValue);

        cmd.Parameters.Add("Metre", txtMetre_Bina.Text);

        cmd.Parameters.Add("BinaYasId", ddlBinaYasi.SelectedValue);

        cmd.ExecuteNonQuery();


        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);




    }

    protected void btnDevreKaydet_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into DevreOzellik(ilanId,DonemId,SureId,Oda) Values(@ilanId,@DonemId,@SureId,@Oda)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("DonemId", ddlDevreDonem.SelectedValue);
        cmd.Parameters.Add("SureId", ddlDevreSure.SelectedValue);
        cmd.Parameters.Add("Oda", txtDevreOda.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);
    }

    protected void btnKonutKaydet_Click(object sender, EventArgs e)
    {
        int binaKat; int bulunduguKat;
        if (txtKonutBinaKat.Text != "" || txtKonutKat.Text != "")
        {
            binaKat = Convert.ToInt32(txtKonutBinaKat.Text);
            bulunduguKat = Convert.ToInt32(txtKonutKat.Text);

            if (binaKat >= bulunduguKat)
            {
                SqlConnection baglanti = klas.baglan();
                SqlCommand cmd = new SqlCommand("insert into KonutOzellikler(ilanId,IsitmaTurId,OdaId,BanyoId,BinaYasId,KrediId,BinadakiKat,BulunduguKat,Metre,DurumId) Values(@ilanId,@IsitmaTurId,@OdaId,@BanyoId,@BinaYasId,@KrediId,@BinadakiKat,@BulunduguKat,@Metre,@DurumId)", baglanti);
                cmd.Parameters.Add("ilanId", ilanId);
                cmd.Parameters.Add("IsitmaTurId", ddlisitma_Konut.SelectedValue);
                cmd.Parameters.Add("OdaId", ddlKonutOdasayisi.SelectedValue);
                cmd.Parameters.Add("BanyoId", ddlKonutBanyoSayisi.Text);
                cmd.Parameters.Add("BinaYasId", ddlKonutBinaYasi.SelectedValue);
                cmd.Parameters.Add("KrediId", ddlKonutKredi.SelectedValue);
                cmd.Parameters.Add("BinadakiKat", txtKonutBinaKat.Text);
                cmd.Parameters.Add("BulunduguKat", txtKonutKat.Text);
                cmd.Parameters.Add("Metre", txtKonutMetre.Text);
                cmd.Parameters.Add("DurumId", ddlKonutBinaDurumu.SelectedValue);
                cmd.ExecuteNonQuery();
                Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);
            }
            else
            {
                lblKonutBilgi.Text = "Lütfen Bulunduğunuz Katı bina Katından fazla girmeyiniz ";
            }
        }




    }

    protected void btnTuristKaydet_Click(object sender, EventArgs e)
    {
        string zeminEtudu = "";
        if (rdVar.Checked == true)
        {
            zeminEtudu = "1";
        }
        else
        {
            zeminEtudu = "0";
        }
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into TesisOzellik(ilanId,YildizId,YatakSayisi,KatSayisi,BinaYasId,AcikAlan,KapaliAlan,ZeminEtudu,KrediId,ApartSayisi) Values(@ilanId,@YildizId,@YatakSayisi,@KatSayisi,@BinaYasId,@AcikAlan,@KapaliAlan,@ZeminEtudu,@KrediId,@ApartSayisi)", baglanti);
        cmd.Parameters.Add("ilanId", ilanId);
        cmd.Parameters.Add("YildizId", ddlTuristYildiz.SelectedValue);
        cmd.Parameters.Add("YatakSayisi", txtTuristYatak.Text);
        cmd.Parameters.Add("KatSayisi", txtTuristKat.Text);
        cmd.Parameters.Add("BinaYasId", ddlTuristBinaYasi.SelectedValue);
        cmd.Parameters.Add("AcikAlan", txtTuristAcikAlan.Text);
        cmd.Parameters.Add("KapaliAlan", txtTuristKapaliAlan.Text);
        cmd.Parameters.Add("ZeminEtudu", zeminEtudu);
        cmd.Parameters.Add("KrediId", ddlTuristKredi.SelectedValue);
        cmd.Parameters.Add("ApartSayisi", txtTuristApart.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("ilanEkle3.aspx?ilanId=" + ilanId);
    }
}