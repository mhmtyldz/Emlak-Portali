using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

public partial class adminpanel_ilanYonetimi : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilanId = ""; string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            dlOnaysiz.Visible = true;
            dlOnayli.Visible = false;
        }
        DataTable dtOnaysiz = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.Onay=0");
        dlOnaysiz.DataSource = dtOnaysiz;
        dlOnaysiz.DataBind();

        DataTable dtOnayli = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik, dbo.ilanResimler.VitrinResim, dbo.Turler.TurAdi, dbo.Kullanici.AdSoyad FROM  dbo.ilanlar INNER JOIN    dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN  dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId INNER JOIN dbo.Kullanici ON dbo.ilanlar.KullaniciId = dbo.Kullanici.KullaniciId Where dbo.ilanlar.Onay=1");
        dlOnayli.DataSource = dtOnayli;
        dlOnayli.DataBind();


        ilanId = Request.QueryString["ilanId"];
        islem = Request.QueryString["islem"];
        if(islem=="Onay")
        {
            klas.cmd("Update ilanlar Set Onay=1 Where ilanId=" + ilanId);
            Response.Redirect("ilanYonetimi.aspx");
        }
        if(islem=="Sil")
        {
            try
            {
                DataRow dtResim = klas.GetDataRow("Select * From ilanlar Where ilanId" + ilanId);
                if (dtResim["VitrinResim"].ToString() != "ResimYok.png")
                {
                    FileInfo FiResim1a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["VitrinResim"].ToString()));
                    FiResim1a.Delete();
                    FileInfo FiResim1b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["VitrinResim"].ToString()));
                    FiResim1b.Delete();
                }
                
                FileInfo FiResim2a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["Resim2"].ToString()));
                FiResim2a.Delete();
                FileInfo FiResim2b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["Resim2"].ToString()));
                FiResim2b.Delete();
                FileInfo FiResim3a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["Resim3"].ToString()));
                FiResim3a.Delete();
                FileInfo FiResim3b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["Resim3"].ToString()));
                FiResim3b.Delete();
                FileInfo FiResim4a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["Resim4"].ToString()));
                FiResim4a.Delete();
                FileInfo FiResim4b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["Resim4"].ToString()));
                FiResim4b.Delete();

                FileInfo FiResim5a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["Resim5"].ToString()));
                FiResim5a.Delete();
                FileInfo FiResim5b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["Resim5"].ToString()));
                FiResim5b.Delete();

                FileInfo FiResim6a = new FileInfo(Server.MapPath("../ilanResimleri/200/" + dtResim["Resim6"].ToString()));
                FiResim6a.Delete();
                FileInfo FiResim6b = new FileInfo(Server.MapPath("../ilanResimleri/700/" + dtResim["Resim6"].ToString()));
                FiResim6b.Delete();




            }
            catch (Exception)
            {}
           

            klas.cmd("Delete From ilanlar Where ilanId=" + ilanId);
            klas.cmd("Delete From ilanResimler Where ilanId=" + ilanId);
            Response.Redirect("ilanYonetimi.aspx");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlOnayli.SelectedItem.Text=="Onaylı")
        {
            dlOnayli.Visible = true;
            dlOnaysiz.Visible = false;
        }
        else
        {
            dlOnayli.Visible = false;
            dlOnaysiz.Visible = true;
        }
    }
}