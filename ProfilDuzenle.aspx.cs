using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class ProfilDuzenle : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KullaniciId"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (Page.IsPostBack == false)
        {
            il();
            meslek();
            ilce();
            ddlilce.Enabled = false;
            DataRow drKul = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.Meslekler.MeslekAdi FROM  dbo.Kullanici INNER JOIN   dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.Meslekler ON dbo.Kullanici.MeslekId = dbo.Meslekler.MeslekId Where dbo.Kullanici.KullaniciId=" + Session["KullaniciId"]);
            txtAdSoyad.Text = drKul["AdSoyad"].ToString();
            ddlil.SelectedValue = drKul["ilId"].ToString();
            ddlilce.SelectedValue = drKul["ilceId"].ToString();
            ddlMeslek.SelectedValue = drKul["MeslekAdi"].ToString();
            txtTel.Text = drKul["Tel"].ToString();

            txtTel2.Text = drKul["Tel2"].ToString();

            txtGsm.Text = drKul["Gsm"].ToString();
            txtGsm2.Text = drKul["Gsm2"].ToString();

            txtFax.Text = drKul["Fax"].ToString();

            txtAdres.Text = drKul["Adres"].ToString();
            imgResim.ImageUrl = "KullaniciResimleri/" + drKul["Resim"].ToString();


        }

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


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    void ilce2()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil.SelectedValue + " order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    void meslek()
    {


        DataTable dtMeslekler = klas.GetDataTable("Select * From Meslekler " + " order by [MeslekAdi]");
        ddlMeslek.DataTextField = "MeslekAdi";
        ddlMeslek.DataValueField = "MeslekId";
        ddlMeslek.DataSource = dtMeslekler;
        ddlMeslek.DataBind();
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        string resimadi = ""; string uzanti = "";
        if (fuResim.HasFile)
        {
            //eski resimler siliniyor
            string resimadi2 = "";
            resimadi2 = klas.GetDataCell("Select Resim From Kullanici Where  KullaniciId=" + Session["KullaniciId"]);

            if(resimadi2!="ResimYok.png")
            {
                if(resimadi2!="ResimYok2.png")
                {
                    FileInfo fiResim = new FileInfo(Server.MapPath("KullaniciResimleri/" + resimadi2));
                    fiResim.Delete();
                }
            }


            //resim yükleniyor..
            DataRow drEmail = klas.GetDataRow("Select Email from Kullanici Where KullaniciId=" + Session["KullaniciId"]);
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
            resimadi = Seo.Temizle(drEmail["Email"].ToString()) + DateTime.Now.Day + uzanti;
            fuResim.SaveAs(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));


            int deger = 250; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("KullaniciResimleri/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuResim.SaveAs(Server.MapPath("KullaniciResimleri/" + uzanti));
                }
                FileInfo fisilinecek = new FileInfo(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));
                fisilinecek.Delete();



            }
        }
        else
        {
            DataRow drResimadi = klas.GetDataRow("Select Resim from Kullanici Where KullaniciId=" + Session["KullaniciId"]);
            resimadi = drResimadi["Resim"].ToString();
        }


        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update Kullanici Set Resim=@Resim,AdSoyad=@AdSoyad,ilId=@ilId,ilceId=@ilceId,MeslekId=@MeslekId,Tel=@Tel,Tel2=@Tel2,Gsm=@Gsm,Gsm2=@Gsm2,Fax=@Fax,Adres=@Adres Where KullaniciId=" + Session["KullaniciId"], baglanti);
        cmd.Parameters.Add("Resim", resimadi);

        cmd.Parameters.Add("AdSoyad", txtAdSoyad.Text);

        cmd.Parameters.Add("ilId", ddlil.SelectedValue);

        cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);

        cmd.Parameters.Add("MeslekId", ddlMeslek.SelectedValue);

        cmd.Parameters.Add("Tel", txtTel.Text);

        cmd.Parameters.Add("Tel2", txtTel2.Text);

        cmd.Parameters.Add("Gsm", txtGsm.Text);

        cmd.Parameters.Add("Gsm2", txtGsm2.Text);

        cmd.Parameters.Add("Fax", txtFax.Text);

        cmd.Parameters.Add("Adres", txtAdres.Text);

        cmd.ExecuteNonQuery();

        Response.Redirect("Profilim.aspx");


    }


    //    protected void ddlilce_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        ilce2();
    //        ddlilce.Enabled = true ;
    //    }

    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce2();
        ddlilce.Enabled = true ;
    }
}