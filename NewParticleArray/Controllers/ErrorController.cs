using System.Net;
using System.Web.Mvc;

namespace NewParticleArray.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int? error)
        {
            // Assign the given error if it exists
            if (error.HasValue)
            {
                Response.StatusCode = error.Value;
            }

            switch (Response.StatusCode)
            {
                case (int)HttpStatusCode.Forbidden:
                    Response.StatusDescription = "Nuh Uh, No Snooping!";
                    ViewBag.Message = "I set things up so you aren't allowed to do that.";
                    break;
                case (int)HttpStatusCode.NotFound:
                    Response.StatusDescription = "File Not Found";
                    ViewBag.Message = "We are all searching for something, but right now the server can't find that web page.";
                    break;
                case (int)HttpStatusCode.InternalServerError:
                    Response.StatusDescription = "All Your Base Are Belong To Us";
                    ViewBag.Message = "Oh no! My code has a really bad bug in it!  Darn, I need to fix that.";
                    break;
                case (int)HttpStatusCode.OK:
                    Response.StatusDescription = "Looking For Trouble?";
                    ViewBag.Message = "You have accessed the URL of the error handling page, but there is actually no error!  There's nothing much to see here.";
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