using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            ilce();
            ddlilce.Items.Insert(0, new ListItem("İlçe Seçebilirsiniz", "0"));

            tur();
            ddlTur.Items.Insert(0, new ListItem("Tür Seçebilirsiniz", "0"));
            

            ddlAltTur.Items.Insert(0, new ListItem("Alttür Seçebilirsiniz", "0"));

        }
        
        DataTable dtVitrin = klas.GetDataTable("SELECT TOP 5  dbo.ilanlar.ilanId, dbo.ilanlar.Fiyat, dbo.ilanlar.Onay, dbo.ilanResimler.VitrinResim, dbo.islemler.islem, dbo.FiyatTurler.FiyatTur," +
                         " dbo.ilceler.ilceAdi, dbo.semt.SemtAdi, dbo.Turler.TurAdi" +
                         " FROM  dbo.ilanlar INNER JOIN  dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN " +
                         " dbo.islemler ON dbo.ilanlar.islemId = dbo.islemler.islemId INNER JOIN " +
                         " dbo.FiyatTurler ON dbo.ilanlar.FiyatTurId = dbo.FiyatTurler.FiyatTurId INNER JOIN " +
                         " dbo.ilceler ON dbo.ilanlar.ilceId = dbo.ilceler.ilceId INNER JOIN " +
                         " dbo.semt ON dbo.ilanlar.SemtId = dbo.semt.SemtId INNER JOIN " +
                         " dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId Where dbo.ilanlar.Onay=1 and dbo.ilanlar.Vitrin=1");

        rpVitrin.DataSource = dtVitrin;
        rpVitrin.DataBind();


        DataTable dtSonEklenen = klas.GetDataTable("SELECT TOP 4  dbo.ilanlar.ilanId, dbo.ilanlar.Tarih,  dbo.ilanlar.Fiyat, dbo.ilanlar.Onay, dbo.ilanResimler.VitrinResim, dbo.islemler.islem, dbo.FiyatTurler.FiyatTur," +
                        " dbo.ilceler.ilceAdi, dbo.semt.SemtAdi, dbo.Turler.TurAdi" +
                        " FROM  dbo.ilanlar INNER JOIN  dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN " +
                        " dbo.islemler ON dbo.ilanlar.islemId = dbo.islemler.islemId INNER JOIN " +
                        " dbo.FiyatTurler ON dbo.ilanlar.FiyatTurId = dbo.FiyatTurler.FiyatTurId INNER JOIN " +
                        " dbo.ilceler ON dbo.ilanlar.ilceId = dbo.ilceler.ilceId INNER JOIN " +
                        " dbo.semt ON dbo.ilanlar.SemtId = dbo.semt.SemtId INNER JOIN " +
                        " dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId Where dbo.ilanlar.Onay=1 Order by[ilanId] desc");

        rpSonEklenen.DataSource = dtSonEklenen;
        rpSonEklenen.DataBind();


        DataTable dtHit = klas.GetDataTable("SELECT TOP 4  dbo.ilanlar.ilanId, dbo.ilanlar.Tarih, dbo.ilanlar.Hit, dbo.ilanlar.Fiyat, dbo.ilanlar.Onay, dbo.ilanResimler.VitrinResim, dbo.islemler.islem, dbo.FiyatTurler.FiyatTur," +
                       " dbo.ilceler.ilceAdi, dbo.semt.SemtAdi, dbo.Turler.TurAdi" +
                       " FROM  dbo.ilanlar INNER JOIN  dbo.ilanResimler ON dbo.ilanlar.ilanId = dbo.ilanResimler.ilanId INNER JOIN " +
                       " dbo.islemler ON dbo.ilanlar.islemId = dbo.islemler.islemId INNER JOIN " +
                       " dbo.FiyatTurler ON dbo.ilanlar.FiyatTurId = dbo.FiyatTurler.FiyatTurId INNER JOIN " +
                       " dbo.ilceler ON dbo.ilanlar.ilceId = dbo.ilceler.ilceId INNER JOIN " +
                       " dbo.semt ON dbo.ilanlar.SemtId = dbo.semt.SemtId INNER JOIN " +
                       " dbo.Turler ON dbo.ilanlar.TurId = dbo.Turler.TurId Where dbo.ilanlar.Onay=1 Order by[Hit] desc");

        rpHit.DataSource = dtHit;
        rpHit.DataBind();



    }
  

    protected void btnAra_Click(object sender, EventArgs e)
    {
        Response.Redirect("ilanlar.aspx?ilceId="+ddlilce.SelectedValue+"&TurId="+ddlTur.SelectedValue+"&AltTurId="+ddlAltTur.SelectedValue+"");
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

    protected void ddlTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        alttur();
        ddlAltTur.Enabled = true;
        ddlAltTur.Items.Insert(0, new ListItem("Alttür Seçebilirsiniz", "0"));

    }
}