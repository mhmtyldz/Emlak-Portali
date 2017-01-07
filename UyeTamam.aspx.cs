using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class UyeTamam : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    string Email = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        int Sayi;
        try
        {
            Email = Request.QueryString["Email"];
        }
        catch (Exception)
        {
        }
        DataRow drSayi = klas.GetDataRow("Select * From Kullanici Where Email='" + Email + "'");
        Sayi = Convert.ToInt32(drSayi["Sayi"].ToString());

        MailMessage msg = new MailMessage();//Yeni bir Mail nesnesi oluşturuldu.
        msg.IsBodyHtml = true;
        msg.To.Add(Email);//Kime mail gönderilecek.
        msg.From = new MailAddress("yildizmahmut0@gmail.com", "MahmutYildiz.com", System.Text.Encoding.UTF8);// Mail kimden geliyor hangi ifade görünsün
        msg.Subject = "Üyelik onay maili";//Mailin konusu

        msg.Body = "<a href='http://www.e-gorselegitim.com/UyeOnay.aspx?x=" + Sayi + "&Email=" + Email + "'>Üyelik Onayı için tıklayın </a>";
        SmtpClient smp = new SmtpClient();
        smp.Credentials = new NetworkCredential("yldzmahmut0@gmail.com", "sifre"); //Kullanici Adi sifre
        smp.Port = 587;
        smp.Host = "smtp.gmail.com";//gmail üzerinden gönderiliyor .
        smp.EnableSsl = true;
        smp.Send(msg);

    }
}