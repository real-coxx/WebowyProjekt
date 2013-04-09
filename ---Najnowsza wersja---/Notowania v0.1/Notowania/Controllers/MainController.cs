using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notowania.Models;

namespace Notowania.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/
        ProjectDBShell db = new ProjectDBShell();

        public ActionResult Index()
        {
            db.Database.Initialize(true);
            return View();
        }

    }
}
