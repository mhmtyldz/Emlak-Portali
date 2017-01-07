using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilanEkle3 : System.Web.UI.Page
{
    Methodlar klas = new Methodlar(); string ilanId = ""; string ilanTurId = "";
    string ArsaTurId = ""; string BinaTurId = ""; string DevreTurId = "";
    string KonutTurId = ""; string isyeriDevrenTurId = ""; string isyeriSatilikTurId = ""; string TuristikTurId = ""; string ilanAltTurId = "";
    string ResAltTurId = ""; string ApartAltTurId = ""; string PansiyonAltTurId = ""; string KampAltTurId = "";
    protected void Page_Load(object sender, EventArgs e)
    {


        ilanId = Request.QueryString["ilanId"];

        ilanTurId = klas.GetDataCell("Select TurId From ilanlar Where ilanId=" + ilanId);

        DataRow drArsa = klas.GetDataRow("Select * From Turler Where TurAdi='" + "Arsa" + "'");
        ArsaTurId = drArsa["TurId"].ToString();

        DataRow drBina = klas.GetDataRow("Select * From Turler Where TurAdi='" + "Bina" + "'");
        BinaTurId = drBina["TurId"].ToString();

        DataRow drDevre = klas.GetDataRow("Select * From Turler Where TurAdi='" + "Devremülk" + "'");
        DevreTurId = drDevre["TurId"].ToString();

        DataRow drKonut = klas.GetDataRow("Select  * From Turler Where TurAdi='" + "Konut" + "'");
        KonutTurId = drKonut["TurId"].ToString();

        DataRow drisyeriDevren = klas.GetDataRow("Select * From Turler Where TurAdi='" + "İşyeri (Devren)" + "'");
        isyeriDevrenTurId = drisyeriDevren["TurId"].ToString();

        DataRow drisyeriSatilik = klas.GetDataRow("Select * From Turler Where TurAdi='" + "İşyeri (Satılık)" + "'");
        isyeriSatilikTurId = drisyeriSatilik["TurId"].ToString();

        DataRow drTuristik = klas.GetDataRow("Select * From Turler Where TurAdi='" + "Turistik Tesis" + "'");
        TuristikTurId = drTuristik["TurId"].ToString();

        ilanAltTurId = klas.GetDataCell("Select AltTurId  From ilanlar Where ilanId=" + ilanId);

        DataRow drResAltTurId = klas.GetDataRow("Select * From AltTurler Where AltTurAdi='" + "Residence" + "'");

        ResAltTurId = drResAltTurId["AltTurId"].ToString();


        DataRow drApartAltTurId = klas.GetDataRow("Select * From AltTurler Where AltTurAdi='" + "Apart Otel" + "'");

        ApartAltTurId = drApartAltTurId["AltTurId"].ToString();


        DataRow drPansiyonAltTurId = klas.GetDataRow("Select * From AltTurler Where AltTurAdi='" + "Pansiyon" + "'");

        PansiyonAltTurId = drPansiyonAltTurId["AltTurId"].ToString();

        DataRow drKampAltTurId = klas.GetDataRow("Select * From AltTurler Where AltTurAdi='" + "Kamp Yeri" + "'");
        KampAltTurId = drKampAltTurId["AltTurId"].ToString();

        KampAltTurId = drKampAltTurId["AltTurId"].ToString();
        if (Page.IsPostBack == false)
        {
            Aktivite(); AltYapi(); BanyoOzellikler(); BinaDetay(); Cephe(); DisOzellikler(); icOzellikler(); KampDetay(); Manzara();
            Muhit(); Mutfak(); OdaOzellikler(); OdaTipi(); OrtakKullanimAlani(); ParselDurumu(); TesisDetay(); Ulasim(); Yeme();
            ResidenceOzellikler(); ResidenceSosyal(); KonutTipi();

        }
        if (ilanTurId == ArsaTurId)
        {
            pnlAltYapi.Visible = true;
            pnlMuhit.Visible = true;
            pnlParsel.Visible = true;
            pnlUlasim.Visible = true;
        }

        if (ilanTurId == BinaTurId)
        {
            pnlBinaDetay.Visible = true;
            pnlCephe.Visible = true;
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }

        if (ilanTurId == DevreTurId)
        {
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }

        if (ilanTurId == isyeriDevrenTurId || ilanTurId == isyeriSatilikTurId)
        {
            pnlCephe.Visible = true;
            pnlDisOzellikler.Visible = true;
            pnlicOzellikler.Visible = true;
            pnlManzara.Visible = true;
            pnlMuhit.Visible = true;
            pnlUlasim.Visible = true;
        }

        if (ilanTurId == KonutTurId)
        {
            if (ilanAltTurId == ResAltTurId)
            {
                pnlCephe.Visible = true;
                pnlicOzellikler.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlResidenceOzellik.Visible = true; ;
                pnlResidenceSosyalOzellik.Visible = true;
            }
            else
            {
                pnlCephe.Visible = true;
                pnlicOzellikler.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlDisOzellikler.Visible = true;
                pnlKonutTipi.Visible = true;

            }
        }
        if (ilanTurId == TuristikTurId)
        {
            if (ilanAltTurId == ApartAltTurId || ilanAltTurId == PansiyonAltTurId)
            {
                pnlBanyoOzellikler.Visible = true;
                pnlAktivite.Visible = true;
                pnlMuhit.Visible = true;
                pnlMutfak.Visible = true;
                pnlOdaOzellikler.Visible = true;
                pnlOdaTipi.Visible = true;
                pnlOrtakKullanimAlani.Visible = true;
                pnlYeme.Visible = true;
            }
            else if (ilanAltTurId == KampAltTurId)
            {
                pnlAktivite.Visible = true;
                pnlKampDetay.Visible = true;
                pnlManzara.Visible = true;
                pnlMuhit.Visible = true;
                pnlUlasim.Visible = true;
                pnlYeme.Visible = true;


            }
            else
            {
                pnlBanyoOzellikler.Visible = true;
                pnlAktivite.Visible = true;
                pnlMuhit.Visible = true;
                pnlMutfak.Visible = true;
                pnlOdaOzellikler.Visible = true;
                pnlOdaTipi.Visible = true;
                pnlUlasim.Visible = true;
                pnlYeme.Visible = true;
                pnlTesisDetay.Visible = true;
            }
        }






    }
    void KonutTipi()
    {


        DataTable dtKonutTipi = klas.GetDataTable("Select * From KonutTipi");
        chckKonutTipi.DataTextField = "KonutTipi";
        chckKonutTipi.DataValueField = "KonutTipiId";
        chckKonutTipi.DataSource = dtKonutTipi;
        chckKonutTipi.DataBind();

    }

    void ResidenceOzellikler()
    {


        DataTable dtResidenceOzellikler = klas.GetDataTable("Select * From ResidenceOzellik");
        chckResidenceOzellik.DataTextField = "ResidenceOzellik";
        chckResidenceOzellik.DataValueField = "ResidenceOzellikId";
        chckResidenceOzellik.DataSource = dtResidenceOzellikler;
        chckResidenceOzellik.DataBind();

    }


    void ResidenceSosyal()
    {


        DataTable dtResidenceSosyal = klas.GetDataTable("Select * From ResidenceSosyal");
        chckResidenceSosyalOzellik.DataTextField = "ResidenceSosyal";
        chckResidenceSosyalOzellik.DataValueField = "ResidenceSosyalId";
        chckResidenceSosyalOzellik.DataSource = dtResidenceSosyal;
        chckResidenceSosyalOzellik.DataBind();

    }


    //Aktiviteler
    void Aktivite()
    {


        DataTable dtAktivite = klas.GetDataTable("Select * From Aktiviteler");
        chckAktivite.DataTextField = "Aktivite";
        chckAktivite.DataValueField = "AktiviteId";
        chckAktivite.DataSource = dtAktivite;
        chckAktivite.DataBind();

    }

    //Alt Yapı
    void AltYapi()
    {


        DataTable dtAltYapi = klas.GetDataTable("Select * From AltYapi");
        chckAltYapi.DataTextField = "AltYapi";
        chckAltYapi.DataValueField = "AltYapiId";
        chckAltYapi.DataSource = dtAltYapi;
        chckAltYapi.DataBind();

    }

    void BanyoOzellikler()
    {


        DataTable dtBanyoOzellik = klas.GetDataTable("Select * From BanyoOzellikler");
        chckBanyoOzellikler.DataTextField = "BanyoOzellik";
        chckBanyoOzellikler.DataValueField = "BanyoOzelliklerId";
        chckBanyoOzellikler.DataSource = dtBanyoOzellik;
        chckBanyoOzellikler.DataBind();

    }


    void BinaDetay()
    {


        DataTable dtBinaDetay = klas.GetDataTable("select * from BinaDetay");
        chckBinaDetay.DataTextField = "BinaDetay";
        chckBinaDetay.DataValueField = "BinaDetayId";
        chckBinaDetay.DataSource = dtBinaDetay;
        chckBinaDetay.DataBind();

    }



    void Cephe()
    {


        DataTable dtCephe = klas.GetDataTable("Select * From Cephe");
        chckCephe.DataTextField = "Cephe";
        chckCephe.DataValueField = "CepheId";
        chckCephe.DataSource = dtCephe;
        chckCephe.DataBind();

    }




    void DisOzellikler()
    {


        DataTable dtDisOzellikler = klas.GetDataTable("Select * From DisOzellikler");
        chckDisOzellikler.DataTextField = "DisOzellik";
        chckDisOzellikler.DataValueField = "DisOzellikId";
        chckDisOzellikler.DataSource = dtDisOzellikler;
        chckDisOzellikler.DataBind();

    }



    void icOzellikler()
    {


        DataTable dtaktivite = klas.GetDataTable("select * from icOzellikler");
        chckicOzellikler.DataTextField = "icOzellik";
        chckicOzellikler.DataValueField = "icOzellikId";
        chckicOzellikler.DataSource = dtaktivite;
        chckicOzellikler.DataBind();

    }


    void KampDetay()
    {


        DataTable dtKampDetay = klas.GetDataTable("Select * From KampDetay");
        chckKampDetay.DataTextField = "KampDetay";
        chckKampDetay.DataValueField = "KampDetayId";
        chckKampDetay.DataSource = dtKampDetay;
        chckKampDetay.DataBind();

    }





    void Manzara()
    {


        DataTable dtManzara = klas.GetDataTable("Select * From Manzara");
        chckManzara.DataTextField = "Manzara";
        chckManzara.DataValueField = "ManzaraId";
        chckManzara.DataSource = dtManzara;
        chckManzara.DataBind();

    }



    void Muhit()
    {


        DataTable dtMuhit = klas.GetDataTable("Select * From Muhit");
        chckMuhit.DataTextField = "Muhit";
        chckMuhit.DataValueField = "MuhitId";
        chckMuhit.DataSource = dtMuhit;
        chckMuhit.DataBind();

    }



    void Mutfak()
    {


        DataTable dtMutfak = klas.GetDataTable("Select * From Muhit");
        chckMuhit.DataTextField = "Muhit";
        chckMuhit.DataValueField = "MuhitId";
        chckMuhit.DataSource = dtMutfak;
        chckMuhit.DataBind();

    }




    void OdaOzellikler()
    {


        DataTable dtOdaOzellikler = klas.GetDataTable("Select * From OdaOzellikler");
        chckOdaOzellikler.DataTextField = "OdaOzellik";
        chckOdaOzellikler.DataValueField = "OdaOzellikId";
        chckOdaOzellikler.DataSource = dtOdaOzellikler;
        chckOdaOzellikler.DataBind();

    }




    void OdaTipi()
    {


        DataTable dtOdaTipi = klas.GetDataTable("Select * From OdaTipi");
        chckOdaTipi.DataTextField = "OdaTipi";
        chckOdaTipi.DataValueField = "OdaTipiId";
        chckOdaTipi.DataSource = dtOdaTipi;
        chckOdaTipi.DataBind();

    }




    void OrtakKullanimAlani()
    {


        DataTable dtOrtakKullanimAlani = klas.GetDataTable("Select * From Ortak");
        chckOrtakKullanimAlani.DataTextField = "Ortak";
        chckOrtakKullanimAlani.DataValueField = "OrtakId";
        chckOrtakKullanimAlani.DataSource = dtOrtakKullanimAlani;
        chckOrtakKullanimAlani.DataBind();

    }




    void ParselDurumu()
    {


        DataTable dtParselDurumu = klas.GetDataTable("Select * From ParselDurumu");
        chckParsel.DataTextField = "ParselDurumu";
        chckParsel.DataValueField = "ParselDurumuId";
        chckParsel.DataSource = dtParselDurumu;
        chckParsel.DataBind();

    }




    void TesisDetay()
    {


        DataTable dtTesisDetay = klas.GetDataTable("Select * From TesisDetay");
        chckTesisDetay.DataTextField = "TesisDetay";
        chckTesisDetay.DataValueField = "TesisDetayId";
        chckTesisDetay.DataSource = dtTesisDetay;
        chckTesisDetay.DataBind();

    }



    void Ulasim()
    {


        DataTable dtUlasim = klas.GetDataTable("Select * From Ulasim");
        chckUlasim.DataTextField = "Ulasim";
        chckUlasim.DataValueField = "UlasimId";
        chckUlasim.DataSource = dtUlasim;
        chckUlasim.DataBind();

    }

    void Yeme()
    {


        DataTable dtYeme = klas.GetDataTable("Select * From Yeme");
        chckYeme.DataTextField = "Yeme";
        chckYeme.DataValueField = "YemeId";
        chckYeme.DataSource = dtYeme;
        chckYeme.DataBind();

    }









    protected void btnKaydet_Click(object sender, EventArgs e)
    {

        //Aktivite Kaydediliyor 
        if (chckAktivite.Items.Count > 0)
        {
            for (int i = 0; i < chckAktivite.Items.Count; i++)
            {
                if (chckAktivite.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliAktiviteler (ilanId,AktiviteId) Values(@ilanId,@AktiviteId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("AktiviteId", chckAktivite.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Alt Yapı  kaydediliyor
        if (chckAltYapi.Items.Count > 0)
        {
            for (int i = 0; i < chckAltYapi.Items.Count; i++)
            {
                if (chckAltYapi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliAltYapi (ilanId,AltYapiId) Values(@ilanId,@AltYapiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("AltYapiId", chckAltYapi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 

        //Banyo Özellikler  kaydediliyor
        if (chckAltYapi.Items.Count > 0)
        {
            for (int i = 0; i < chckBanyoOzellikler.Items.Count; i++)
            {
                if (chckBanyoOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliBanyoOzellikler (ilanId,BanyoOzellikId) Values(@ilanId,@BanyoOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("BanyoOzellikId", chckBanyoOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 

        //Bina Detay  kaydediliyor
        if (chckBinaDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckBinaDetay.Items.Count; i++)
            {
                if (chckBinaDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliBinaDetay (ilanId,BinaDetayId) Values(@ilanId,@BinaDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("BinaDetayId", chckBinaDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 

        //Cephe Özellikleri  kaydediliyor
        if (chckCephe.Items.Count > 0)
        {
            for (int i = 0; i < chckCephe.Items.Count; i++)
            {
                if (chckCephe.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliCephe (ilanId,CepheId) Values(@ilanId,@CepheId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("CepheId", chckCephe.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 


        //Dış Özellikleri  kaydediliyor
        if (chckDisOzellikler.Items.Count > 0)
        {
            for (int i = 0; i < chckDisOzellikler.Items.Count; i++)
            {
                if (chckDisOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliDisOzellikler (ilanId,DisOzellikId) Values(@ilanId,@DisOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("DisOzellikId", chckDisOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 



        //İç Özellikleri  kaydediliyor
        if (chckicOzellikler.Items.Count > 0)
        {
            for (int i = 0; i < chckicOzellikler.Items.Count; i++)
            {
                if (chckicOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliicOzellikler (ilanId,icOzellikId) Values(@ilanId,@icOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("icOzellikId", chckicOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 


        //Kamp Detay Özellikleri  kaydediliyor
        if (chckKampDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckKampDetay.Items.Count; i++)
            {
                if (chckKampDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliKampDetay (ilanId,KampDetayId) Values(@ilanId,@KampDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("KampDetayId", chckKampDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 

        //Manzara Özellikleri  kaydediliyor
        if (chckManzara.Items.Count > 0)
        {
            for (int i = 0; i < chckManzara.Items.Count; i++)
            {
                if (chckManzara.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliManzara (ilanId,ManzaraId) Values(@ilanId,@ManzaraId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ManzaraId", chckManzara.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 


        //Muhit Özellikleri  kaydediliyor
        if (chckMuhit.Items.Count > 0)
        {
            for (int i = 0; i < chckMuhit.Items.Count; i++)
            {
                if (chckMuhit.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliMuhit (ilanId,MuhitId) Values(@ilanId,@MuhitId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("MuhitId", chckMuhit.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 



        //Mutfak Özellikleri  kaydediliyor
        if (chckMutfak.Items.Count > 0)
        {
            for (int i = 0; i < chckMutfak.Items.Count; i++)
            {
                if (chckMutfak.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliMutfak (ilanId,MutfakId) Values(@ilanId,@MutfakId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("MutfakId", chckMutfak.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 



        //Oda Özellikleri  kaydediliyor
        if (chckOdaOzellikler.Items.Count > 0)
        {
            for (int i = 0; i < chckOdaOzellikler.Items.Count; i++)
            {
                if (chckOdaOzellikler.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliOdaOzellikler (ilanId,OdaOzellikId) Values(@ilanId,@OdaOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OdaOzellikId", chckOdaOzellikler.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 



        //OdaTipi   kaydediliyor
        if (chckOdaTipi.Items.Count > 0)
        {
            for (int i = 0; i < chckOdaTipi.Items.Count; i++)
            {
                if (chckOdaTipi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliOdaTipi (ilanId,OdaTipiId) Values(@ilanId,@OdaTipiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OdaTipiId", chckOdaTipi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 


        //Ortak Kullanım Alanları   kaydediliyor
        if (chckOrtakKullanimAlani.Items.Count > 0)
        {
            for (int i = 0; i < chckOrtakKullanimAlani.Items.Count; i++)
            {
                if (chckOrtakKullanimAlani.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliOrtak (ilanId,OrtakId) Values(@ilanId,@OrtakId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("OrtakId", chckOrtakKullanimAlani.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor 


        //ParselDurumu   kaydediliyor
        if (chckParsel.Items.Count > 0)
        {
            for (int i = 0; i < chckParsel.Items.Count; i++)
            {
                if (chckParsel.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliParselDurumu (ilanId,ParselDurumuId) Values(@ilanId,@ParselDurumuId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ParselDurumuId", chckParsel.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor



        //TesisDetay   kaydediliyor
        if (chckTesisDetay.Items.Count > 0)
        {
            for (int i = 0; i < chckTesisDetay.Items.Count; i++)
            {
                if (chckTesisDetay.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliTesisDetay (ilanId,TesisDetayId) Values(@ilanId,@TesisDetayId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("TesisDetayId", chckTesisDetay.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor




        //Ulaşım   kaydediliyor
        if (chckUlasim.Items.Count > 0)
        {
            for (int i = 0; i < chckUlasim.Items.Count; i++)
            {
                if (chckUlasim.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliUlasim (ilanId,UlasimId) Values(@ilanId,@UlasimId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("UlasimId", chckUlasim.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor





        //Yeme   kaydediliyor
        if (chckYeme.Items.Count > 0)
        {
            for (int i = 0; i < chckYeme.Items.Count; i++)
            {
                if (chckYeme.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliYeme (ilanId,YemeId) Values(@ilanId,@YemeId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("YemeId", chckYeme.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor





        //Residence Özellikler   kaydediliyor
        if (chckResidenceOzellik.Items.Count > 0)
        {
            for (int i = 0; i < chckResidenceOzellik.Items.Count; i++)
            {
                if (chckResidenceOzellik.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliResidenceOzellikler (ilanId,ResidenceOzellikId) Values(@ilanId,@ResidenceOzellikId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ResidenceOzellikId", chckResidenceOzellik.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor




        //ResidenceSosyalÖzellikler  kaydediliyor
        if (chckResidenceSosyalOzellik.Items.Count > 0)
        {
            for (int i = 0; i < chckResidenceSosyalOzellik.Items.Count; i++)
            {
                if (chckResidenceSosyalOzellik.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliResidenceSosyal (ilanId,ResidenceSosyalId) Values(@ilanId,@ResidenceSosyalId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("ResidenceSosyalId", chckResidenceSosyalOzellik.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //// Bitiyor

        //Konut Tipi  kaydediliyor
        if (chckKonutTipi.Items.Count > 0)
        {
            for (int i = 0; i < chckKonutTipi.Items.Count; i++)
            {
                if (chckKonutTipi.Items[i].Selected)
                {
                    SqlConnection baglanti = klas.baglan();
                    SqlCommand cmd = new SqlCommand("Insert into SeciliKonutTipi (ilanId,KonutTipiId) Values(@ilanId,@KonutTipiId)", baglanti);
                    cmd.Parameters.Add("ilanId", ilanId);
                    cmd.Parameters.Add("KonutTipiId", chckKonutTipi.Items[i].Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //// Bitiyor
        Response.Redirect("ilanEkle4.aspx?ilanId="+ilanId);
    }
}