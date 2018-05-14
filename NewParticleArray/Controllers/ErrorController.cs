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
                case (int)HttpStatusCode.NotFound:
                    Response.StatusDescription = "File Not Found";
                    ViewBag.Message = "We are all searching for something, but right now the server can't find that web page.  Sorry about that!";
                    break;
                case (int)HttpStatusCode.InternalServerError:
                    Response.StatusDescription = "Internal Server Error";
                    ViewBag.Message = "Oh no! There is something wrong with my code.  My bad!";
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