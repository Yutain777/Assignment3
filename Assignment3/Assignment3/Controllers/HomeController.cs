using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Assignment3.Controllers
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
        
        public ActionResult Contact(Assignment3.Models.EmailFromModel model)
        {
            if (ModelState.IsValid)
            {
                string from = "nichel0777@gmail.com"; //example:- sourabh9303@gmail.com
                using (MailMessage mail = new MailMessage(from, "zhanchenchang@163.com"))
                {
                    mail.Subject = "test";
                    mail.Body = "Body";
               
            //       mail.Attachments.Add(new Attachment(Server.MapPath("~/MyFile.txt")));

                    

                    mail.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential networkCredential = new NetworkCredential(from, "Xiaott99639");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCredential;
                    smtp.Port = 587;
                    smtp.Send(mail);
                    ViewBag.Message = "Sent";
                    //return View( model);
                    return View(model);
                }
            }
            else
            {
                return View();
            }
        }
    

       

        public ActionResult ToDo()
        {
            return View();
        }
    }
}