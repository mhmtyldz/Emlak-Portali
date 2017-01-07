using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ilanEkle5 : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilanId = ""; string adsoyad = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ilanId = Request.QueryString["ilanId"];
        ltrlilanId.Text = ilanId;
        adsoyad = klas.GetDataCell("select AdSoyad From Kullanici Where KullaniciId=" + Session["KullaniciId"]);
        ltrlAdSoyad.Text = adsoyad;
    }
}