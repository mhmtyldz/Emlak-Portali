using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_GrupGuncelle : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string GrupId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        GrupId = Request.QueryString["GrupId"];

        if(Page.IsPostBack==false)
        {
            DataRow drGrup = klas.GetDataRow("Select * From KullaniciGrup Where GrupId=" + GrupId);
            txtGrupAdi.Text = drGrup["GrupAdi"].ToString();
        }




    }

    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update KullaniciGrup Set GrupAdi=@GrupAdi Where GrupId="+GrupId,baglanti);
        cmd.Parameters.Add("GrupAdi", txtGrupAdi.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("GrupYonetimi.aspx");

    }
}