using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Login : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGiris_Click(object sender, EventArgs e)
    {
        DataRow drGiris = klas.GetDataRow("select * from Kullanici where KullaniciAdi='" +Seo.Temizle( txtKullaniciAdi.Text) + "' and Sifre='" +Seo.Temizle( txtSifre.Text )+ "' and GrupId=1");
        if(drGiris!=null)
        {
            Session["KullaniciId"] = drGiris["KullaniciId"].ToString();
            Response.Redirect("Default.aspx");

        }
        else
        {
            lblBilgi.Text = "Kullanıcı Adı veya Şifre Hatalı";
        }

    }
}