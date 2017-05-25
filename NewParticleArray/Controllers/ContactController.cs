using System;
using System.Web.Mvc;
using System.Net.Mail;
using NewParticleArray.Models;
using System.Text;
using System.Configuration;

namespace NewParticleArray.Controllers
{
    public class ContactController : Controller
    {

        public ActionResult Index()
        {
            // Use session variable so only one email get's sent at a time, even when form is refreshed
            Session["MailSent"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel c)
        {
            if (ModelState.IsValid)
            {
                // If the mail has NOT been sent yet, send it
                if (!(bool)Session["MailSent"])
                {
                    try
                    {
                        MailMessage msg = new MailMessage();
                        SmtpClient client = new SmtpClient();
                        MailAddress from = new MailAddress(c.Email.ToString());
                        StringBuilder sb = new StringBuilder();

                        msg.To.Add(ConfigurationManager.AppSettings["MailTo"]);
                        msg.Subject = "Message from Website!";
                        msg.IsBodyHtml = false;
                        sb.Append(c.Message);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(c.Name);
                        sb.Append(Environment.NewLine);
                        sb.Append(c.Email);
                        msg.Body = sb.ToString();

                        client.Send(msg);
                        msg.Dispose();

                        Session["MailSent"] = c.Success = true;
                        ViewBag.Title = "Message Sent";
                        ViewBag.Message = "I should get back to you soon!";
                    }
                    catch (Exception ex)
                    {
                        Session["MailSent"] = c.Success = false;
                        ViewBag.Title = "Couldn't Send";
                        ViewBag.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
                    }
                }

                // If the mail HAS already been sent, set the model data to succes!
                else
                {
                    c.Success = (bool)Session["MailSent"];
                }

                return View("Result", c);
            }

            return View();
        }


        // Returns the failed sent model back to the original Contact view
        public ActionResult Retry(ContactModel c)
        {
            c.Success = false;
            return View("Index", c);
        }
    }
}