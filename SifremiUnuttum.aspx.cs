using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
public partial class SifremiUnuttum : System.Web.UI.Page
{
    Methodlar klas = new Methodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnGonder_Click(object sender, EventArgs e)
    {
        DataRow drKul = klas.GetDataRow("Select * From Kullanici Where Email='" + txtEmail.Text + "'");
        if(drKul!=null)
        {
            MailMessage msg = new MailMessage();//Yeni bir Mail nesnesi oluşturuldu.
            msg.IsBodyHtml = true;
            msg.To.Add(txtEmail.Text);//Kime mail gönderilecek.
            msg.From = new MailAddress("yldzmahmut0@gmail.com", "MahmutYildiz.com", System.Text.Encoding.UTF8);// Mail kimden geliyor hangi ifade görünsün
            msg.Subject = "Kullanıcı Bilgileri Hatırlatma Maili";//Mailin konusu

            msg.Body = "Şifreniz :" + drKul["Sifre"].ToString()+ "<br> Giriş Yapmak için Tıklan <a href='http://www.ankaraevbul.com'></a>";
            SmtpClient smp = new SmtpClient();
            smp.Credentials = new NetworkCredential("mertsari397@gmail.com", "123mehmet45"); //Kullanici Adi sifre
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";//gmail üzerinden gönderiliyor .
            smp.EnableSsl = true;
            smp.Send(msg);
            lblEmail.Text = "Bilgileriniz Mail Adresinize Gönderilmiştir.";
        }
        else
        {
            lblEmail.Text = "Sitemizde Böyle bir Mail adresi Kayıtlı Değildir!";
        }
        

       


       
    }
}