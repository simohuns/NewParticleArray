using NewParticleArray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NewParticleArray.Controllers
{
    public class ProjectsController : Controller
    {
        private DBModel _db = new DBModel();

        public ActionResult Index()
        {
            List<Projects> projects;

            try
            {
                projects = _db.Projects.OrderBy(p => p.SequenceNo).ToList();
            }
            catch (Exception ex)
            {
                projects = null;
            }

            return View(projects);
        }
    }
}