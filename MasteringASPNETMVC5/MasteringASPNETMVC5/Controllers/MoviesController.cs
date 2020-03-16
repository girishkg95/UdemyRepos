using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasteringASPNETMVC5.Models;

namespace MasteringASPNETMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie mv = new Movie() { Id = 1, Name = "Shrek!" };
            
            return View(mv);
        }
    }
}