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
            List<Project> projects;

            try
            {
                projects = _db.Project.OrderBy(p => p.SequenceNo).ToList();
            }
            catch (Exception ex)
            {
                // Add a default error project
                projects = new List<Project>
                {
                    new Project()
                    {
                        ProjectLink = System.Web.Configuration.WebConfigurationManager.AppSettings["ErrorVideo"],
                        ImageTitle = ex.Message,
                        ProjectTitle = ex.Source,
                        ProjectText =  ex.Message
                    }
                };
            }

            return View(projects);
        }
    }
}