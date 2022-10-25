using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WindowsFormOturumAcmaIslemleriSifreMailHatirlatma.Models;

namespace WindowsFormOturumAcmaIslemleriSifreMailHatirlatma.Models
{
    public class MailGonderici
    {
        WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntities db = new WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntities();

        public void Microsoft (string AliciMail, string GondericiMail, string GondericiPass)
        {
            PersonelGirisTablosu p = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == GondericiMail);
            
            Random rnd = new Random();
            int rasgelesayi = rnd.Next(1000, 10000);
            //p.Password = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("dogukanyasar.79@gmail.com", "qlvfxckmtthhnlgc");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("dogukanyasar.79@gmail.com");
            mail.To.Add(AliciMail);
            mail.Subject = "şifre değiştirme talebi: " + rasgelesayi;
            mail.Body = mail.Body;
            //sc.Send(mail);
            //mail.From = new MailAddress(GondericiMail, "dogukanyasar.79@gmail.com");
            //mail.Body = $@"{DateTime.Now.ToString()} tarihinde şifre sıfırlama talebinde bulundunuz. yeni şifreniz {p.Password}";

            sc.Send(mail);
           
        }

    }
}
