using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Expires = 0;
        Response.Cache.SetNoStore();
        Response.AppendHeader("Pragma", "no-cache");//Güvenlik için 3 satır yazdık
        if(Request.Cookies["Cerezim"]!=null)
        {
            HttpCookie yakalanancerez = Request.Cookies["Cerezim"];//Cookie yi yakalıyruz 
            Session["KullaniciId"] = yakalanancerez.Values["KullaniciId"];
            Session["AdSoyad"] = yakalanancerez.Values["AdSoyad"];

        }
        if(Session["KullaniciId"]!=null)
        {
            pnlKulGiris.Visible = false;
            pnlKulBilgi.Visible = true;
            lblAdSoyad.Text = Session["AdSoyad"].ToString();
        }
        else
        {
            pnlKulGiris.Visible = true;
            pnlKulBilgi.Visible = false;
        }
    }

    protected void imgGiris_Click(object sender, ImageClickEventArgs e)
    {
        DataRow drMail = klas.GetDataRow("Select * From Kullanici Where Email='" + txtEmail.Text + "'");

        if (drMail != null)
        {
            DataRow drOnay = klas.GetDataRow("Select * From Kullanici Where Email='" + txtEmail.Text + "'  And Onay=1 ");
            if (drOnay != null)
            {
                DataRow drGiris = klas.GetDataRow("Select * From Kullanici Where Email='" + txtEmail.Text + "' And Sifre='" + txtSifre.Text + "' ");
                if(drGiris!=null)
                {
                    Session["KullaniciId"] = drGiris["KullaniciId"].ToString();
                    Session["AdSoyad"] = drGiris["AdSoyad"].ToString();
                    if(chckHatirla.Checked)
                    {
                        HttpCookie cerez = new HttpCookie("Cerezim");//Cerezim isimli bir cooki oluşturuldu.
                        cerez.Values.Add("KullaniciId", drGiris["KullaniciId"].ToString());//cookie değer atadık
                        cerez.Values.Add("AdSoyad", drGiris["AdSoyad"].ToString());
                        cerez.Expires = DateTime.Now.AddDays(30);//cookie 30 gün kullanılabilir.
                        Response.Cookies.Add(cerez);//cookie Eklendi.


                    }
                    Response.Redirect(Page.Request.Url.ToString(),true);
                }
                else
                {
                    lblGirisHata.Text = "Şifreyi Hatalı girdiniz!";
                }
            }
            else
            {
                lblGirisHata.Text = "Üyeliğiniz Henüz onaylanmamıştır";
            }

        }
        else
        {
            lblGirisHata.Text = "Bu Mail Adresi Sitemizde Kayıtlı Değildir.";

        }


    }

    protected void lbCikis_Click(object sender, EventArgs e)
    {
        if(Request.Cookies["Cerezim"]!=null)
        {
            Response.Cookies["Cerezim"].Expires = DateTime.Now.AddDays(-1);
        }
        FormsAuthentication.SignOut();
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void lbUnuttum_Click(object sender, EventArgs e)
    {
        Response.Redirect("SifremiUnuttum.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Profilim.aspx");
    }
}
