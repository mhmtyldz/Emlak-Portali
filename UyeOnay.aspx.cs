using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UyeOnay : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string x;
    string Email = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            x = Request.QueryString["x"];
            Email = Request.QueryString["x"];

        }
        catch (Exception)
        {
        }
        DataRow drSayi = klas.GetDataRow("Select Sayi From Kullanici Where Email='" + Email + "'");
        if (x == drSayi["Sayi"].ToString()) ;
        {
            klas.cmd("Update Kullanici Set Onay=1 Where Email='" + Email + "'");
        }

    }
}