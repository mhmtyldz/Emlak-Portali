using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.IO;
using System.Drawing;
using System.Web.UI.WebControls;

public partial class UyeOl : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    int sayi; int sayi2;



    protected void Page_Load(object sender, EventArgs e)
    {
        Random sayi2 = new Random();
        sayi = sayi2.Next();
        if(Page.IsPostBack==false)
        {
            il();
            ddlil.Items.Insert(0, new ListItem("Seçiniz", "0"));
            meslek();
           

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


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil.SelectedValue + " order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    void meslek()
    {


        DataTable dtMeslekler = klas.GetDataTable("Select * From Meslekler " +  " order by [MeslekAdi]");
        ddlMeslek.DataTextField = "MeslekAdi";
        ddlMeslek.DataValueField = "MeslekId";
        ddlMeslek.DataSource = dtMeslekler;
        ddlMeslek.DataBind();
    }

    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilce.Enabled = true;
        ilce();
    }

    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        string resimadi = "";
        string cinsiyet = "";
        string grupId = "";
        string uzanti = "";
        if(rdErkek.Checked==true)
        {
            cinsiyet = "Erkek";
        }
        else
        {
            cinsiyet = "Bayan";
        }

        if(rdKullanici.Checked==true)
        {
            grupId = klas.GetDataCell("Select GrupId From KullaniciGrup Where GrupAdi='" + "Kullanıcı" + "'");
        }

        else
        {
            grupId = klas.GetDataCell("Select GrupId From KullaniciGrup Where GrupAdi='" + "Emlakçı" + "'");
        }
        DataRow drMail = klas.GetDataRow("Select * From Kullanici Where Email='" + Seo.Temizle(txtEmail.Text) + "'");

        

        if (fuResim.HasFile)
        {
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
            resimadi = Seo.Temizle(txtEmail.Text) + DateTime.Now.Day + uzanti;
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
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("KullaniciResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();





        }

        else
        {
            if(rdErkek.Checked)
            {
                resimadi = "bay_icon.png";
            }
            else
            {
                resimadi = "bayan_icon.png";
            }
        }

        if(drMail==null)
        {
            
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Insert Into Kullanici(Email,Sifre,AdSoyad,Gsm,Gsm2,Tel,Tel2,Fax,MeslekId,Cinsiyet,ilId,ilceId,Dogum,Resim,Adres,GrupId,Sayi) Values(@Email,@Sifre,@AdSoyad,@Gsm,@Gsm2,@Tel,@Tel2,@Fax,@MeslekId,@Cinsiyet,@ilId,@ilceId,@Dogum,@Resim,@Adres,@GrupId,@Sayi)", baglanti);
            cmd.Parameters.Add("Email",Seo.Temizle(txtEmail.Text));
            cmd.Parameters.Add("Sifre", Seo.Temizle(txtSifre.Text));
            cmd.Parameters.Add("AdSoyad", txtAdSoyad.Text);
            cmd.Parameters.Add("Gsm", txtGsm.Text);
            cmd.Parameters.Add("Gsm2", txtGsm2.Text);
            cmd.Parameters.Add("Tel", txtTel.Text);
            cmd.Parameters.Add("Tel2", txtTel2.Text);
            cmd.Parameters.Add("Fax", txtFax.Text);
            cmd.Parameters.Add("MeslekId", ddlMeslek.SelectedValue);
            cmd.Parameters.Add("Cinsiyet", cinsiyet);
            cmd.Parameters.Add("ilId", ddlil.SelectedValue);
            cmd.Parameters.Add("ilceId", ddlilce.SelectedValue);
            cmd.Parameters.Add("Dogum", txtDogum.Text);
            cmd.Parameters.Add("Resim", resimadi);
            cmd.Parameters.Add("Adres", txtAdres.Text);
            cmd.Parameters.Add("GrupId",grupId);
            cmd.Parameters.Add("Sayi", sayi);
            cmd.ExecuteNonQuery();
            Response.Redirect("UyeTamam.aspx?Email=" + txtEmail.Text);

        }
        else
        {
            lblBilgi.Text = "Bu Email Adresi Mevcuttur. Lütfen Başka mail adresi seçiniz";
        }
     
    }
}