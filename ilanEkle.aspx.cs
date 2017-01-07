using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilanEkle : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KullaniciId"] == null)
        {
            Response.Redirect("GirisYap.aspx");
        }
        if (Page.IsPostBack == false)
        {
            tur();
            ddlilanTur.Items.Insert(0, new ListItem("Seçiniz", "0"));
            islem();
            fiyattur();
            kimden();
            il();
            ddlil.Items.Insert(0, new ListItem("Seçiniz", "0"));

        }


    }

    void tur()
    {
        DataTable dtTur = klas.GetDataTable("Select * From Turler Order By[TurAdi]");
        ddlilanTur.DataTextField = "TurAdi";
        ddlilanTur.DataValueField = "TurId";
        ddlilanTur.DataSource = dtTur;
        ddlilanTur.DataBind();
    }

    void alttur()
    {
        DataTable dtAltTur = klas.GetDataTable("Select * From AltTurler Where TurId=" + ddlilanTur.SelectedValue + " Order By[AltTurAdi]");
        ddlilanAltTur.DataTextField = "AltTurAdi";
        ddlilanAltTur.DataValueField = "AltTurId";
        ddlilanAltTur.DataSource = dtAltTur;
        ddlilanAltTur.DataBind();
    }

    void islem()
    {
        DataTable dtislem = klas.GetDataTable("Select * From islemler Order By[islem] desc");
        ddlislem.DataTextField = "islem";
        ddlislem.DataValueField = "islemId";
        ddlislem.DataSource = dtislem;
        ddlislem.DataBind();
    }

    void fiyattur()
    {
        DataTable dtfiyattur = klas.GetDataTable("Select * From FiyatTurler Order By[FiyatTur] desc");
        ddlFiyatTur.DataTextField = "FiyatTur";
        ddlFiyatTur.DataValueField = "FiyatTurId";
        ddlFiyatTur.DataSource = dtfiyattur;
        ddlFiyatTur.DataBind();
    }

    void kimden()
    {
        DataTable dtkimden = klas.GetDataTable("Select * From Kimden Order By[Kimden] desc");
        ddlKimden.DataTextField = "Kimden";
        ddlKimden.DataValueField = "KimdenId";
        ddlKimden.DataSource = dtkimden;
        ddlKimden.DataBind();
    }



    void il()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
    }
    void ilce()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil.SelectedValue + " order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    void semt()
    {


        DataTable dtsemt = klas.GetDataTable("Select * From semt Where ilceId=" + ddlilce.SelectedValue + " order by [semtAdi]");
        ddlSemt.DataTextField = "semtAdi";
        ddlSemt.DataValueField = "semtId";
        ddlSemt.DataSource = dtsemt;
        ddlSemt.DataBind();
    }

    void mahalle()
    {


        DataTable dtmahalle = klas.GetDataTable("Select * From mahalle Where semtId=" + ddlSemt.SelectedValue + " order by [mahalleAdi]");
        ddlMahalle.DataTextField = "mahalleAdi";
        ddlMahalle.DataValueField = "mahalleId";
        ddlMahalle.DataSource = dtmahalle;
        ddlMahalle.DataBind();
    }

    protected void ddlilanTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilanAltTur.Enabled = true;
        alttur();
    }

    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {

        ddlilce.Enabled = true;
        ilce();
        ddlilce.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddlilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlSemt.Enabled = true;
        semt();
        ddlSemt.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddlSemt_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlMahalle.Enabled = true;
        mahalle();

    }

    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        if (ddlilanTur.SelectedValue != "0")
        {
            if (ddlil.SelectedValue != "0")
            {
                if (ddlilce.SelectedValue != "0")
                {
                    if (ddlSemt.SelectedValue != "0")
                    {
                        string takas = "";
                        if (rdTakasEvet.Checked == true)
                        {
                            takas = "1";
                        }

                        else
                        {
                            takas = "0";
                        }
                        SqlConnection baglanti = klas.baglan();
                        SqlCommand cmd = new SqlCommand("Insert Into ilanlar(TurId,AltTurId,islemId,FiyatTurId,Fiyat,KimdenId,KullaniciId,ilId,ilceId,SemtId,mahalleId,Baslik,Aciklama,Adres,Tarih,Takas,Onay,Vitrin,Hit) Values(@TurId,@AltTurId,@islemId,@FiyatTurId,@Fiyat,@KimdenId,@KullaniciId,@ilId,@ilceId,@SemtId,@mahalleId,@Baslik,@Aciklama,@Adres,@Tarih,@Takas,@Onay,@Vitrin,@Hit)", baglanti);
                        cmd.Parameters.Add("TurId", ddlilanTur.SelectedValue);
                        cmd.Parameters.Add("AltTurId", ddlilanAltTur.SelectedValue);
                        cmd.Parameters.Add("islemId", ddlislem.SelectedValue);
                        cmd.Parameters.Add("FiyatTurId", ddlFiyatTur.SelectedValue);
                        cmd.Parameters.Add("Fiyat", txtFiyat.Text);
                        cmd.Parameters.Add("KimdenId", ddlKimden.SelectedValue);
                        cmd.Parameters.Add("KullaniciId", Session["KullaniciId"]);
                        cmd.Parameters.Add("ilId", ddlil.SelectedValue);
                        cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);
                        cmd.Parameters.Add("SemtId", ddlSemt.SelectedValue);
                        cmd.Parameters.Add("mahalleId", ddlMahalle.SelectedValue);
                        cmd.Parameters.Add("Baslik", txtBaslik.Text);
                        cmd.Parameters.Add("Aciklama", txtAciklama.Text);
                        cmd.Parameters.Add("Adres", txtAdres.Text);
                        cmd.Parameters.Add("Tarih", DateTime.Now.ToShortDateString());
                        cmd.Parameters.Add("Takas", takas);
                        cmd.Parameters.Add("Onay", "0");
                        cmd.Parameters.Add("Vitrin", "0");
                        cmd.Parameters.Add("Hit", "0");
                        cmd.ExecuteNonQuery();
                        Response.Redirect("ilanEkle2.aspx");

                    }
                    else
                    {
                        ltrlHata.Text = "Semt Seçmek Zorundasınız.";
                    }

                }
                else
                {
                    ltrlHata.Text = "İlçe Seçmek Zorundasınız.";
                }
            }
            else
            {
                ltrlHata.Text = "il Seçmek Zorundasınız.";
            }
        }
        else
        {
            ltrlHata.Text = "İlan Türü Seçmek Zorundasınız.";
        }



    }
}