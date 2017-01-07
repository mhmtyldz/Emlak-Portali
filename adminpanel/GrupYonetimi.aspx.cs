using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_GrupYonetimi : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string GrupId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        GrupId = Request.QueryString["GrupId"];
        islem = Request.QueryString["islem"];
        if(islem=="sil")
        {
            klas.cmd("Delete From KullaniciGrup Where GrupId=" + GrupId);
        }

        DataTable dtGruplar = klas.GetDataTable("Select * From KullaniciGrup");
        rpGruplar.DataSource = dtGruplar;
        rpGruplar.DataBind();
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into KullaniciGrup(GrupAdi) values(@GrupAdi)", baglanti);
        cmd.Parameters.Add("GrupAdi", txt_GrupAdi.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("GrupYonetimi.aspx");

    }
}