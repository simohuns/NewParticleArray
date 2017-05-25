using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewParticleArray.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int error)
        {
            Response.StatusCode = error;

            switch (error)
            {
                case 404:
                    Response.StatusDescription = "File Not Found";
                    ViewBag.Message = "We are all searching for something, but right now the server can't find that web page.  Sorry about that!";
                    break;
                case 500:
                    Response.StatusDescription = "Internal Server Error";
                    ViewBag.Message = "Ugh... there is a typo in my code syntax, or else something didn't compile right.  My bad!";
                    break;
                default:
                    Response.StatusDescription = "Error!";
                    ViewBag.Message = "That was odd.  I have no idea why that happened, but something broke.";
                    break;
            }

            return View();
        }
    }
}