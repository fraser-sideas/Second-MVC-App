using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Second_MVC_App.Models;

namespace Second_MVC_App.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Random()
        {
            var album = new Album() { Name = "Mylo Xyloto" };

           return View(album);
            
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(pageIndex + sortBy);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}