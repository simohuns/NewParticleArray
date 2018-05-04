using NewParticleArray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NewParticleArray.Controllers
{
    public class HomeController : Controller
    {
        private DBModel _db = new DBModel();

        public ActionResult Index()
        {
            List<Slide> slides;

            try
            {
                // Order by sequence number descending to make first slide in sequence the last in the HTML (and thus the first visible)
                slides = _db.Slide.OrderByDescending(s => s.SequenceNo).ToList();
            }
            catch (Exception ex)
            {
                // Add a default error slide
                slides = new List<Slide>
                {
                    new Slide()
                    {
                        SlideTitle = ex.Message
                    }
                };
            }

            return View(slides);
        }
    }
}