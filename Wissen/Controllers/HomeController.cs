using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Wissen.Controllers
{ 
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact( String name,string lastName,string email,string phone, string subject,
           string message)
        { 
            //TODU: Mail gönde4rme işlemi yapılacak
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

            mailMessage.From = new System.Net.Mail.MailAddress("gonderen@gmail.com", "Gönderen Firma Adı");
            mailMessage.Subject = "İletişim Formu: " + name;

            mailMessage.To.Add("alici@firmaadi.com,digeralici@gmail.com");

            string body;
            body = "Ad Soyad: " + name +" " +lastName + "<br />";
            body += "Telefon: " + phone + "<br />";
            body += "E-posta: " + email + "<br />";
            body += "Konu: " +  message + "<br />";
            body += "Mesaj: " + subject + "<br />";        
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("gonderen@gmail.com", "gondereninmailsifresi");
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            ViewBag.Message = "Mesajınız gönderildi. Teşekkür ederiz.";
            ViewBag.Message = "Form başarıyla iletildi, en kısa zamanda dönüş yapacağız.";
            return View();
        }

          
        
    }
}