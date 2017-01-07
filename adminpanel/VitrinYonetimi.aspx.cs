using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_VitrinYonetimi : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string islem = ""; string kelime = ""; string secim = ""; string ilanId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        islem = Request.QueryString["islem"];
        kelime = Request.QueryString["kelime"];
        secim = Request.QueryString["secim"];
        ilanId = Request.QueryString["ilanId"];
        if (islem == "ara")
        {
            if (kelime != null)
            {
                if (secim == "İlan Adına Göre")
                {
                    DataTable dtAra = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik,dbo.ilanlar.Vitrin,dbo.ilanlar.Vitrinilce, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.Baslik like '%" + kelime + "%'");
                    if (dtAra.Rows.Count > 0)
                    {
                        dlAra.Visible = true;
                        dlilceVitrin.Visible = false;
                        dlVitrin.Visible = false;
                        dlAra.DataSource = dtAra;
                        dlAra.DataBind();
                    }

                    else
                    {
                        dlAra.Visible = false;
                    }

                }
                if (secim == "İlan Nosuna Göre")
                {
                    DataTable dtAra = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik,dbo.ilanlar.Vitrin,dbo.ilanlar.Vitrinilce, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.ilanId like '%" + kelime + "%'");
                    if (dtAra.Rows.Count > 0)
                    {
                        dlAra.Visible = true;
                        dlilceVitrin.Visible = false;
                        dlVitrin.Visible = false;
                        dlAra.DataSource = dtAra;
                        dlAra.DataBind();
                    }
                    else
                    {
                        dlAra.Visible = false;
                    }
                }
                if (secim == "Ad Soyada Göre")
                {
                    DataTable dtAra = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik,dbo.ilanlar.Vitrin,dbo.ilanlar.Vitrinilce, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.Kullanici.AdSoyad like '%" + kelime + "%'");
                    if (dtAra.Rows.Count > 0)
                    {
                        dlAra.Visible = true;
                        dlilceVitrin.Visible = false;
                        dlVitrin.Visible = false;
                        dlAra.DataSource = dtAra;
                        dlAra.DataBind();
                    }
                    else
                    {
                        dlAra.Visible = false;
                    }

                }
            }
        }
        if(islem=="vitrin")
        {
            klas.cmd("Update ilanlar Set Vitrin=1 Where ilanId=" + ilanId);
            Response.Redirect("VitrinYonetimi.aspx");
        }
        if(islem=="ilcevitrin")
        {
            klas.cmd("Update ilanlar Set Vitrinilce=1 Where ilanId=" + ilanId);
            Response.Redirect("VitrinYonetimi.aspx");
        }
        if(islem=="vitrincikar")
        {
            klas.cmd("Update ilanlar Set Vitrin=0 Where ilanId=" + ilanId);
            Response.Redirect("VitrinYonetimi.aspx");
        }

        if (islem == "ilcevitrincikar")
        {
            klas.cmd("Update ilanlar Set Vitrinilce=0 Where ilanId=" + ilanId);
            Response.Redirect("VitrinYonetimi.aspx");
        }
    }

    protected void btnAra_Click(object sender, EventArgs e)
    {
        Response.Redirect("VitrinYonetimi.aspx?islem=ara&kelime=" + txtAra.Text + "&secim=" + ddlAra.SelectedItem.Text);

    }

    protected void ddlVitrin_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlVitrin.SelectedItem.Text=="Vitrin")
        {
            dlVitrin.Visible = true;
            dlilceVitrin.Visible = false;
            dlAra.Visible = false; 

            DataTable dtVitrin = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik,dbo.ilanlar.Vitrin,dbo.ilanlar.Vitrinilce, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.Vitrin=1");
            if (dtVitrin.Rows.Count > 0)
            {
                dlVitrin.Visible = true;
                dlVitrin.DataSource = dtVitrin;
                dlVitrin.DataBind();
            }

        }
        if(ddlVitrin.SelectedItem.Text == "İlçe Vitrin")
        {
            dlAra.Visible = false;
            dlVitrin.Visible = false;
            dlilceVitrin.Visible = true;
            ilce();
            ddlilce.Items.Insert(0, new ListItem("Seçiniz","0"));
            ddlilce.Visible = true;
        }
    }

    void ilce()
    {
        string ilId = "";
        ilId = klas.GetDataCell("Select ilId From iller Where ilAdi='"+"Ankara"+"'");

        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ilId + " order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    protected void ddlilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        dlAra.Visible = false;
        DataTable dtilceVitrin = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik,dbo.ilanlar.Vitrin,dbo.ilanlar.Vitrinilce, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.Vitrinilce=1 and dbo.ilanlar.ilceId="+ddlilce.SelectedValue);
        if (dtilceVitrin.Rows.Count > 0)
        {
            dlilceVitrin.Visible = true;
            dlilceVitrin.DataSource = dtilceVitrin;
            dlilceVitrin.DataBind();
        }
        else
        {
            dlilceVitrin.Visible = false;
        }

    }
}