using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_ilYonetimi : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            il();
            ddlil.Items.Insert(0,new ListItem("Seçiniz", "0"));
            ilce_il();
            ddl_ilce_il.Items.Insert(0, new ListItem("Seçiniz", "0"));

            il3();
            ddl_il3.Items.Insert(0, new ListItem("Seçiniz", "0"));

            il4();
            ddlil4.Items.Insert(0, new ListItem("Seçiniz", "0"));

           




        }

    }

  

    void il()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
    }

    void ilce_il()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddl_ilce_il.DataTextField = "ilAdi";
        ddl_ilce_il.DataValueField = "ilId";
        ddl_ilce_il.DataSource = dtiller;
        ddl_ilce_il.DataBind();
    }

    void il3()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddl_il3.DataTextField = "ilAdi";
        ddl_il3.DataValueField = "ilId";
        ddl_il3.DataSource = dtiller;
        ddl_il3.DataBind();
    }


    void il4()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil4.DataTextField = "ilAdi";
        ddlil4.DataValueField = "ilId";
        ddlil4.DataSource = dtiller;
        ddlil4.DataBind();
    }


    void ilce3()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddl_il3.SelectedValue + " order by [ilceAdi]");
        ddl_ilce3.DataTextField = "ilceAdi";
        ddl_ilce3.DataValueField = "ilceId";
        ddl_ilce3.DataSource = dtilceler;
        ddl_ilce3.DataBind();
    }
    void ilce4()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil4.SelectedValue + " order by [ilceAdi]");
        ddlilce4.DataTextField = "ilceAdi";
        ddlilce4.DataValueField = "ilceId";
        ddlilce4.DataSource = dtilceler;
        ddlilce4.DataBind();
    }


    void semt()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From semt  Where ilceId=" + ddl_ilce3.SelectedValue + " order by [SemtAdi]");
        ddl_semt.DataTextField = "SemtAdi";
        ddl_semt.DataValueField = "SemtId";
        ddl_semt.DataSource = dtilceler;
        ddl_semt.DataBind();
    }


    void semt4()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From semt  Where ilceId=" + ddlilce4.SelectedValue + " order by [SemtAdi]");
        ddlsemt4.DataTextField = "SemtAdi";
        ddlsemt4.DataValueField = "SemtId";
        ddlsemt4.DataSource = dtilceler;
        ddlsemt4.DataBind();
    }


    void mahalle4()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From mahalle  Where SemtId=" + ddlsemt4.SelectedValue + " order by [MahalleAdi]");
        ddlmahalle4.DataTextField = "MahalleAdi";
        ddlmahalle4.DataValueField = "MahalleId";
        ddlmahalle4.DataSource = dtilceler;
        ddlmahalle4.DataBind();
    }





    void ilce()
    {
       

        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddl_ilce_il.SelectedValue + " order by [ilceAdi]");
        ddl_ilce.DataTextField = "ilceAdi";
        ddl_ilce.DataValueField = "ilceId";
        ddl_ilce.DataSource = dtilceler;
        ddl_ilce.DataBind();
    }

    protected void ddlil_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        txtil.Text = ddlil.SelectedItem.Text;
    }

    protected void guncelleil_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update iller set ilAdi=@ilAdi where ilId="+ddlil.SelectedValue,baglanti);
        cmd.Parameters.Add("ilAdi", txtil.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        pnlil.Visible = true;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
        pnlMahalle.Visible = false;
    }

    protected void ddl_ilce_il_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddl_ilce.Enabled = true;
        ilce();
        ddl_ilce.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddl_ilce_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtilce.Text = ddl_ilce.SelectedItem.Text;
    }

    protected void btnGuncelleilce_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update ilceler set ilceAdi=@ilceAdi where ilceId=" + ddl_ilce.SelectedValue, baglanti);
        cmd.Parameters.Add("ilceAdi", txtilce.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        pnlilce.Visible = true;
        pnlil.Visible = false;
        pnlsemt.Visible = false;
        pnlMahalle.Visible = false;
    }

    protected void ddl_il3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddl_ilce3.Enabled = true;
        ilce3();
        ddl_ilce3.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddl_ilce3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddl_semt.Enabled = true;
        semt();
        ddl_semt.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddl_semt_SelectedIndexChanged(object sender, EventArgs e)
    {
        txt_semt.Text = ddl_semt.SelectedItem.Text;
    }

    protected void btnGuncelleSemt_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update Semt  set SemtAdi=@SemtAdi where SemtId=" + ddl_semt.SelectedValue, baglanti);
        cmd.Parameters.Add("SemtAdi", txt_semt.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        pnlsemt.Visible = true;
        pnlilce.Visible = false;
        pnlil.Visible = false;
        pnlMahalle.Visible = false;
    }

    protected void ddlil4_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlilce4.Enabled = true;
        ilce4();

        ddlilce4.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddlilce4_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlsemt4.Enabled = true;
        semt4();
        ddlsemt4.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

    protected void ddlsemt4_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlmahalle4.Enabled = true;
        mahalle4();
        ddlmahalle4.Items.Insert(0, new ListItem("Seçiniz", "0"));
    }

   

    protected void ddlmahalle4_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMahalle.Text = ddlmahalle4.SelectedItem.Text;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlsemt.Visible = false;
        pnlMahalle.Visible = true;
    }

    protected void btnMahalleGuncelle_Click(object sender, EventArgs e)
    {
        
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("Update mahalle  set MahalleAdi=@MahalleAdi where MahalleId=" + ddlmahalle4.SelectedValue, baglanti);
        cmd.Parameters.Add("MahalleAdi", txtMahalle.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("ilYonetimi.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ililceEkle.aspx");
    }

    protected void btnEvetil_Click(object sender, EventArgs e)
    {
        if(ddlil.SelectedItem.Text!="Seçiniz")
        {
            klas.cmd("Delete From iller Where ilId=" + ddlil.SelectedValue);
            Response.Redirect("ilYonetimi.aspx");
        }
        
    }
}