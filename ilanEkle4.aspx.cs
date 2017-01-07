using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;

public partial class ilanEkle4 : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string ilanId = ""; string baslik = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ilanId = Request.QueryString["ilanId"];
        baslik = klas.GetDataCell("select Baslik From ilanlar Where ilanId=" + ilanId);



    }

    protected void btnVitrin_Click(object sender, EventArgs e)
    {
        string resimadi = ""; string uzanti = "";
        pnl_vitrin_a.Visible = false;
        pnl_vitrin_b.Visible = true;
        pnl_res2_a.Visible = true;
        if (fuVitrin.HasFile)
        {

            uzanti = Path.GetExtension(fuVitrin.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_vitrin_" + ilanId + uzanti;
            fuVitrin.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuVitrin.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuVitrin.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into ilanResimler (ilanId,VitrinResim) values(@ilanId,@VitrinResim)",baglanti);
            cmd.Parameters.Add("ilanId", ilanId);
            cmd.Parameters.Add("VitrinResim",resimadi);
            cmd.ExecuteNonQuery();
            imgVitrin.ImageUrl = "ilanResimleri/200/"+resimadi;
            
        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into ilanResimler (ilanId,VitrinResim) values(@ilanId,@VitrinResim)", baglanti);
            cmd.Parameters.Add("ilanId", ilanId);
            cmd.Parameters.Add("VitrinResim", "ResimYok.png");
            cmd.ExecuteNonQuery();
        }


    }

    protected void btniki_Click(object sender, EventArgs e)
    {
        pnl_res2_a.Visible = false;
        pnl_res2_b.Visible = true;
        pnl_res3_a.Visible = true;
       
        if (fuiki.HasFile)
        {
            string uzanti = ""; string resimadi = "";

            uzanti = Path.GetExtension(fuiki.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_resim2_" + ilanId + uzanti;
            fuiki.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuiki.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuiki.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim2=@Resim2 where ilanId="+ilanId, baglanti);
            cmd.Parameters.Add("Resim2", resimadi);
            cmd.ExecuteNonQuery();
            imgRes2.ImageUrl = "ilanResimleri/200/" + resimadi;

        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim2=@Resim2 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim2", "Resimyok.png");
            cmd.ExecuteNonQuery();
        }

    }

    protected void btnuc_Click(object sender, EventArgs e)
    {
        pnl_res3_a.Visible = false;
        pnl_res3_b.Visible = true;
        pnl_res4_a.Visible = true;

        if (fuuc.HasFile)
        {
            string uzanti = ""; string resimadi = "";

            uzanti = Path.GetExtension(fuuc.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_resim3_" + ilanId + uzanti;
            fuuc.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuuc.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuuc.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim3=@Resim3 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim3", resimadi);
            cmd.ExecuteNonQuery();
            imgRes3.ImageUrl = "ilanResimleri/200/" + resimadi;

        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim3=@Resim3 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim3", "Resimyok.png");
            cmd.ExecuteNonQuery();
        }

    }

    protected void btnDort_Click(object sender, EventArgs e)
    {
        pnl_res4_a.Visible = false;
        pnl_res4_b.Visible = true;
        pnl_res5_a.Visible = true;

        if (fuDort.HasFile)
        {
            string uzanti = ""; string resimadi = "";

            uzanti = Path.GetExtension(fuDort.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_resim4_" + ilanId + uzanti;
            fuDort.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuDort.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuDort.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim4=@Resim4 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim4", resimadi);
            cmd.ExecuteNonQuery();
            imgRes4.ImageUrl = "ilanResimleri/200/" + resimadi;

        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim4=@Resim4 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim4", "Resimyok.png");
            cmd.ExecuteNonQuery();
        }
    }

    protected void btnBes_Click(object sender, EventArgs e)
    {
        pnl_res5_a.Visible = false;
        pnl_res5_b.Visible = true;
        pnl_res6_a.Visible = true;

        if (fuBes.HasFile)
        {
            string uzanti = ""; string resimadi = "";

            uzanti = Path.GetExtension(fuBes.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_resim5_" + ilanId + uzanti;
            fuBes.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuBes.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuBes.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim5=@Resim5 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim5", resimadi);
            cmd.ExecuteNonQuery();
            imgRes5.ImageUrl = "ilanResimleri/200/" + resimadi;

        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim5=@Resim5 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim5", "Resimyok.png");
            cmd.ExecuteNonQuery();
        }
    }

    protected void btnAlti_Click(object sender, EventArgs e)
    {
        pnl_res6_a.Visible = false;
        pnl_res6_b.Visible = true;

        if (fuAlti.HasFile)
        {
            string uzanti = ""; string resimadi = "";

            uzanti = Path.GetExtension(fuAlti.PostedFile.FileName);
            resimadi = Seo.Temizle(baslik) + "_resim6_" + ilanId + uzanti;
            fuAlti.SaveAs(Server.MapPath("ilanResimleri/Silinecek" + uzanti));


            int deger = 200; // Resmin ufaltılacağı boyut 

            Bitmap resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/200/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuAlti.SaveAs(Server.MapPath("ilanResimleri/200/" + uzanti));
                }
            }

            deger = 700; // Resmin ufaltılacağı boyut 

            resim = new Bitmap(Server.MapPath("ilanResimleri/Silinecek" + uzanti));// Silinecek resmimizin boyutunu bitmap yapıyoruz 
            using (Bitmap yeniResim = resim)
            {
                double Yukseklik = yeniResim.Height;
                double Genislik = yeniResim.Width;
                double Oran = 0;
                if (Genislik >= deger)
                {
                    Oran = Genislik / Yukseklik;
                    Genislik = deger;
                    Yukseklik = deger / Oran;

                    Size yenidegerler = new Size(Convert.ToInt32(Genislik), Convert.ToInt32(Yukseklik));
                    Bitmap SonResim = new Bitmap(yeniResim, yenidegerler);
                    SonResim.Save(Server.MapPath("ilanResimleri/700/" + resimadi));
                    SonResim.Dispose();
                    yeniResim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    fuAlti.SaveAs(Server.MapPath("ilanResimleri/700/" + uzanti));
                }
            }
            FileInfo fisilinecek = new FileInfo(Server.MapPath("ilanResimleri/Silinecek" + uzanti));
            fisilinecek.Delete();

            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim6=@Resim6 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim6", resimadi);
            cmd.ExecuteNonQuery();
            imgRes6.ImageUrl = "ilanResimleri/200/" + resimadi;

        }
        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("Update ilanResimler set Resim6=@Resim6 where ilanId=" + ilanId, baglanti);
            cmd.Parameters.Add("Resim6", "Resimyok.png");
            cmd.ExecuteNonQuery();
        }
    }

    protected void btnDevam_Click(object sender, EventArgs e)
    {
        string sonResim = "";
        sonResim = klas.GetDataCell("Select VitrinResim From ilanResimler Where ilanId=" + ilanId);

        if(sonResim!=null)
        {
            Response.Redirect("ilanEkle5.aspx?ilanId=" + ilanId);
        }

        else
        {
            SqlConnection baglanti = klas.baglan();
            SqlCommand cmd = new SqlCommand("insert into ilanResimler (ilanId,VitrinResim) values(@ilanId,@VitrinResim)", baglanti);
            cmd.Parameters.Add("ilanId", ilanId);
            cmd.Parameters.Add("VitrinResim", "ResimYok.png");
            cmd.ExecuteNonQuery();
            Response.Redirect("ilanEkle5.aspx?ilanId="+ilanId);

        }
        
    }
}