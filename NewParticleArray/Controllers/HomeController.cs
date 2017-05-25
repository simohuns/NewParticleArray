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
            List<Slides> slides;

            try
            {
                // Order by sequence number descending to make first slide in sequence the last in the HTML (and thus the first visible)
                slides = _db.Slides.OrderByDescending(s => s.SequenceNo).ToList();
            }
            catch (Exception ex)
            {
                slides = null;
            }

            return View(slides);
        }
    }
}