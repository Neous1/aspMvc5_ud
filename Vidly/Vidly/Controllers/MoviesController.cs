using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    [System.Runtime.InteropServices.Guid("29F251BD-7674-4416-9D6C-8CCDEEDA64EC")]
    public class MoviesController : Controller
    {
        // GET: Movies/Random 
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shreck"};
            ViewData["Movie"] = movie;
            return View();
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year +"/"+ month);
        }
 /*
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
        }*/
    }
}