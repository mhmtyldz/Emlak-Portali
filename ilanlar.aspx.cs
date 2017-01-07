using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilanlar : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilceId = ""; string TurId = ""; string AltTurId = ""; string ver = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        ilceId = Request.QueryString["ilceId"];
        TurId = Request.QueryString["TurId"];
        AltTurId = Request.QueryString["AltTurId"];
        if (Page.IsPostBack == false)
        {
            ilce();
            ddlilce.SelectedValue = ilceId;
            ddlilce.Items.Insert(0, new ListItem("İlçe Seçebilirsiniz", "0"));
            if (ddlilce.SelectedValue == "0")
                lbilceKaldir.Visible = false;


            tur();
            ddlTur.SelectedValue = TurId;
            ddlTur.Items.Insert(0, new ListItem("Tür Seçebilirsiniz", "0"));
            if (ddlTur.SelectedValue == "0")
                lbTurKaldir.Visible = false;

            alttur();
            ddlAltTur.Items.Insert(0, new ListItem("Alttür Seçebilirsiniz", "0"));
            ddlAltTur.SelectedValue = AltTurId;
            if (ddlAltTur.SelectedValue == "0")
                lbAltTurKaldir.Visible = false;
        }



        if (ilceId != "0")
        {
            ver = "Where dbo.ilanlar.ilceId=" + ilceId + "";
        }
        if (TurId != "0")
        {
            ver = "Where dbo.ilanlar.TurId=" + TurId + "";
        }
        if (AltTurId != "0")
        {
            ver = "Where dbo.ilanlar.AltTurId=" + AltTurId + "";
        }

        if (ilceId != "0" && TurId != "0")
        {
            ver = "Where dbo.ilanlar.TurId=" + TurId + " and  dbo.ilanlar.ilceId=" + ilceId + "";
        }

        if (ilceId != "0" && AltTurId != "0")
        {
            ver = "Where dbo.ilanlar.AltTurId=" + AltTurId + " and  dbo.ilanlar.ilceId=" + ilceId + "";
        }

        if (ilceId == "0" && TurId == "0" && AltTurId == "0")
        {
            ver = "";
            rpilanlar.Visible = false;
        }



        DataTable dtilanlar = klas.GetDataTable("SELECT  dbo.ilanlar.ilanId, dbo.ilanlar.Baslik, dbo.ilanlar.Fiyat, dbo.ilanlar.Tarih, dbo.ilanlar.Onay, dbo.ilanResimler.VitrinResim, dbo.islemler.islem, dbo.ilceler.ilceAdi, dbo.AltTurler.AltTurAdi," +
                         " dbo.FiyatTurler.FiyatTur" +
                         " FROM  dbo.ilanlar INNER JOIN" +
                         " dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN" +
                         " dbo.islemler ON dbo.ilanlar.islemId = dbo.islemler.islemId INNER JOIN" +
                         " dbo.ilceler ON dbo.ilanlar.ilceId = dbo.ilceler.ilceId INNER JOIN" +
                         " dbo.AltTurler ON dbo.ilanlar.AltTurId = dbo.AltTurler.AltTurId INNER JOIN" +
                         " dbo.FiyatTurler ON dbo.ilanlar.FiyatTurId = dbo.FiyatTurler.FiyatTurId " + ver);
        rpilanlar.DataSource = dtilanlar;
        rpilanlar.DataBind();
    }

    void tur()
    {
        DataTable dtTur = klas.GetDataTable("Select * From Turler Order By[TurAdi]");
        ddlTur.DataTextField = "TurAdi";
        ddlTur.DataValueField = "TurId";
        ddlTur.DataSource = dtTur;
        ddlTur.DataBind();
    }

    void alttur()
    {
        DataTable dtAltTur = klas.GetDataTable("Select * From AltTurler Where TurId=" + ddlTur.SelectedValue + " Order By[AltTurAdi]");
        ddlAltTur.DataTextField = "AltTurAdi";
        ddlAltTur.DataValueField = "AltTurId";
        ddlAltTur.DataSource = dtAltTur;
        ddlAltTur.DataBind();
    }

    void ilce()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=6 order by [ilceAdi]");
        ddlilce.DataTextField = "ilceAdi";
        ddlilce.DataValueField = "ilceId";
        ddlilce.DataSource = dtilceler;
        ddlilce.DataBind();
    }

    protected void btnListele_Click(object sender, EventArgs e)
    {
        Response.Redirect("ilanlar.aspx?ilceId=" + ddlilce.SelectedValue + "&TurId=" + ddlTur.SelectedValue + "&AltTurId=" + ddlAltTur.SelectedValue + "");
    }

    protected void ddlTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        alttur();
        ddlAltTur.Items.Insert(0, new ListItem("Alttür Seçebilirsiniz", "0"));
        lbTurKaldir.Visible = true;
        ddlAltTur.Enabled = true;
       

    }

    protected void lbilceKaldir_Click(object sender, EventArgs e)
    {
        ddlilce.SelectedValue = "0";
        lbilceKaldir.Visible = false;
    }

    protected void lbTurKaldir_Click(object sender, EventArgs e)
    {
        ddlTur.SelectedValue = "0";
        lbTurKaldir.Visible = false;
        lbAltTurKaldir.Visible = false;
        ddlAltTur.SelectedValue = "0";
        ddlAltTur.Enabled = false;
    }

    protected void lbAltTurKaldir_Click(object sender, EventArgs e)
    {
        ddlAltTur.SelectedValue = "0";
        lbAltTurKaldir.Visible = false;
    }

    protected void ddlilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbilceKaldir.Visible = true;
    }

    protected void ddlAltTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbAltTurKaldir.Visible = true;
    }
}