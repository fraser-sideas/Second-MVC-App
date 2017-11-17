using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Second_MVC_App.Models;
using Second_MVC_App.ViewModels;

namespace Second_MVC_App.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var model = AlbumsDatabase;

            return View(model);

        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }


        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(pageIndex + sortBy);
        //}

        [Route("albums/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public static List<Album> AlbumsDatabase = new List<Album>
        {
            new Album
            {
                Id = 1,
                Name = "Mylo Xyloto",
                Rating = 10,
                Length = 48,
                Artist = "Coldplay"
            },

            new Album
            {
                Id = 2,
                Name = "Only the Night",
                Rating = 8,
                Length = 50,
                Artist = "Kings of Leon"
            },

            new Album
            {
                Id = 3,
                Name = "Hot Fuss",
                Rating = 9,
                Length = 39,
                Artist = "The Killers"
            },
        };
    }



}



