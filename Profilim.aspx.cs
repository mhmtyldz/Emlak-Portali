using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profilim : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["KullaniciId"]==null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            LinkButton lblprofil = (LinkButton)Master.Master.FindControl("lbProfil");
            lblprofil.Visible = false;
            DataRow drKul = klas.GetDataRow("SELECT dbo.Kullanici.*, dbo.iller.ilAdi, dbo.ilceler.ilceAdi, dbo.Meslekler.MeslekAdi FROM  dbo.Kullanici INNER JOIN   dbo.iller ON dbo.Kullanici.ilId = dbo.iller.ilId INNER JOIN dbo.ilceler ON dbo.Kullanici.ilceId = dbo.ilceler.ilceId INNER JOIN dbo.Meslekler ON dbo.Kullanici.MeslekId = dbo.Meslekler.MeslekId Where dbo.Kullanici.KullaniciId=" + Session["KullaniciId"]);
            lblAdSoyad.Text = drKul["AdSoyad"].ToString();
            lblil.Text = drKul["ilAdi"].ToString();
            lblilce.Text = drKul["ilceAdi"].ToString();
            lblMeslek.Text = drKul["MeslekAdi"].ToString();
            
            if(drKul["Tel"].ToString()!=null && drKul["Tel"].ToString()!="")
            {
                lblTel.Text = drKul["Tel"].ToString();
            }
            else
            {
                lblTel.Text = "Telefon numarası Mevcut Değildir.";
            }

            if (drKul["Tel2"].ToString() != null && drKul["Tel2"].ToString() != "")
            {
                lblTel2.Text = drKul["Tel2"].ToString();
            }
            else
            {
                lblTel2.Text = "Telefon2 numarası Mevcut Değildir.";
            }

            if (drKul["Gsm"].ToString() != null && drKul["Gsm"].ToString() != "")
            {
                lblGsm.Text = drKul["Gsm"].ToString();
            }
            else
            {
                lblGsm.Text = "Gsm Bilgisi Mevcut Değildir.";
            }
            if (drKul["Gsm2"].ToString() != null && drKul["Gsm2"].ToString() != "")
            {
                lblGsm2.Text = drKul["Gsm2"].ToString();
            }
            else
            {
                lblGsm2.Text = "Gsm2 Bilgisi Mevcut Değildir.";
            }

            lblEmail.Text = drKul["Email"].ToString();


            if (drKul["Adres"].ToString() != null && drKul["Adres"].ToString() != "")
            {
                lblAdres.Text = drKul["Adres"].ToString();
            }
            else
            {
                lblAdres.Text = "Adres Bilgisi Mevcut Değildir.";
            }

            if (drKul["Fax"].ToString() != null && drKul["Fax"].ToString() != "")
            {
                lblFax.Text = drKul["Fax"].ToString();
            }
            else
            {
                lblFax.Text = "Fax Bilgisi Mevcut Değildir.";
            }

            ltrlResim.Text = drKul["Resim"].ToString();



        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProfilDuzenle.aspx");

    }
}