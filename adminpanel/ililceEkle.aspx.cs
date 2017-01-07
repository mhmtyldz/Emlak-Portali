using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_ililceEkle : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            il();
            ddlil.Items.Insert(0, new ListItem("Seçiniz", "0"));
            il2();
            ddlil2.Items.Insert(0, new ListItem("Seçiniz", "0"));
            il3();
            ddlil3.Items.Insert(0, new ListItem("Seçiniz", "0"));

        }

    }

    protected void btnilEkle_Click(object sender, EventArgs e)
    {
        pnlil.Visible = true;
        pnlSemt.Visible = false;
        pnlMahalle.Visible = false;
       
        pnlilce.Visible = false;
    }

    protected void btn_ilEkle_Click(object sender, EventArgs e)
    {
        DataRow dril = klas.GetDataRow("Select * from iller Where ilAdi='" + txtil1.Text + "'");
        if (dril == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into iller(ilAdi) values(@ilAdi)", baglanti);
            cmd.Parameters.Add("ilAdi", txtil1.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");
        }

        else
            lblBilgi1.Text = "Eklemek istediğiniz il Bulunmaktadır";

    }

    protected void btnilceEkle_Click(object sender, EventArgs e)
    {
        pnlilce.Visible = true;
        pnlSemt.Visible = false;
        pnlMahalle.Visible = false;
        pnlil.Visible = false;
       
    }


    void il()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil.DataTextField = "ilAdi";
        ddlil.DataValueField = "ilId";
        ddlil.DataSource = dtiller;
        ddlil.DataBind();
    }

    void il2()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil2.DataTextField = "ilAdi";
        ddlil2.DataValueField = "ilId";
        ddlil2.DataSource = dtiller;
        ddlil2.DataBind();
    }
    void il3()
    {
        DataTable dtiller = klas.GetDataTable("Select * From iller " + "order by [ilAdi]");
        ddlil3.DataTextField = "ilAdi";
        ddlil3.DataValueField = "ilId";
        ddlil3.DataSource = dtiller;
        ddlil3.DataBind();
    }

    void ilce2()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil2.SelectedValue + " order by [ilceAdi]");
        ddlilce2.DataTextField = "ilceAdi";
        ddlilce2.DataValueField = "ilceId";
        ddlilce2.DataSource = dtilceler;
        ddlilce2.DataBind();
    }
    void ilce3()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From ilceler Where ilId=" + ddlil3.SelectedValue + " order by [ilceAdi]");
        ddlilce3.DataTextField = "ilceAdi";
        ddlilce3.DataValueField = "ilceId";
        ddlilce3.DataSource = dtilceler;
        ddlilce3.DataBind();
    }

    void semt4()
    {


        DataTable dtilceler = klas.GetDataTable("Select * From semt  Where ilceId=" + ddlilce3.SelectedValue + " order by [SemtAdi]");
        ddlsemt.DataTextField = "SemtAdi";
        ddlsemt.DataValueField = "SemtId";
        ddlsemt.DataSource = dtilceler;
        ddlsemt.DataBind();
    }

    protected void btn_ilceEkle_Click(object sender, EventArgs e)
    {
        DataRow drilce = klas.GetDataRow("Select * from ilceler Where ilceAdi='" + txtilce.Text + "'");
        if (drilce == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into ilceler(ilceAdi,ilId) values(@ilceAdi,@ilId)", baglanti);
            cmd.Parameters.Add("ilceAdi", txtilce.Text);
            cmd.Parameters.Add("ilId", ddlil.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");

        }
        else
        {
            lblBilgi2.Text = "Eklemek istediğiniz ilce bulunmaktadır..";
        }

    }

    protected void ddlil2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce2();
        ddlilce2.Items.Insert(0, new ListItem("Seçiniz", "0"));

    }

    protected void btn_semtEkle_Click(object sender, EventArgs e)
    {
        DataRow drsemt = klas.GetDataRow("Select * from semt Where SemtAdi='" + txtSemt.Text + "'");
        if (drsemt == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into semt(SemtAdi,ilceId) values(@SemtAdi,@ilceId)", baglanti);
            cmd.Parameters.Add("SemtAdi", txtSemt.Text);
            cmd.Parameters.Add("ilceId", ddlilce2.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");

        }
        else
        {
            lblBilgi2.Text = "Eklemek istediğiniz Semt bulunmaktadır..";
        }
    }

    protected void btnSemtEkle_Click(object sender, EventArgs e)
    {
        pnlSemt.Visible = true;
        pnlMahalle.Visible = false;
        pnlil.Visible = false;
        pnlilce.Visible = false;
      
    }

    protected void ddlil3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilce3();
        ddlilce3.Items.Insert(0, new ListItem("Seçiniz", "0"));

    }

    protected void ddlilce3_SelectedIndexChanged(object sender, EventArgs e)
    {
        semt4();
        ddlsemt.Items.Insert(0, new ListItem("Seçiniz", "0"));

    }

    protected void btn_mahalleEkle_Click(object sender, EventArgs e)
    {
        DataRow drMahalle = klas.GetDataRow("Select * from mahalle Where MahalleAdi='" + txtMahalle.Text + "'");
        if (drMahalle == null)
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into mahalle (MahalleAdi,SemtId) values(@MahalleAdi,@SemtId)", baglanti);
            cmd.Parameters.Add("MahalleAdi", txtMahalle.Text);
            cmd.Parameters.Add("SemtId", ddlsemt.SelectedValue);
            cmd.ExecuteNonQuery();
            Response.Redirect("ilYonetimi.aspx");

        }
        else
        {
            lblBilgi4.Text = "Eklemek istediğiniz Mahalle bulunmuştur.";
        }

    }
    protected void btnMahalleEkle_Click(object sender, EventArgs e)
    {
        pnlMahalle.Visible = true;
        pnlil.Visible = false;
        pnlilce.Visible = false;
        pnlSemt.Visible = false;
    }
}
