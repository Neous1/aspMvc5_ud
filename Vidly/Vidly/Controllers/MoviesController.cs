using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random 
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shreck"};
            //put movie model in the view so it can be rendered
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        //optional parameters, 
        //mke pageIndex nullable
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}