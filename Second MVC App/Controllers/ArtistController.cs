using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Second_MVC_App.Models;

namespace Second_MVC_App.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index(string artist)
        {
            var singleArtist = ArtistDatabase.Find(p => p.Name == artist);
            if (singleArtist == null)
            {
                return View(ArtistDatabase);
            }

            return View("ArtistProfile", singleArtist);
        }

        static List<Artist> ArtistDatabase = new List<Artist>
        {
            new Artist
            {
                Id = 1,
                Name = "Kings of Leon",
                Formed = 2003,
                Image = "https://consequenceofsound.files.wordpress.com/2017/04/kings-of-leon-2017-tour-dates.png"
            },

            new Artist
            {
                Id = 2,
                Name = "Coldplay",
                Formed = 1999,
                Image = "https://consequenceofsound.files.wordpress.com/2015/02/coldplay.jpg?quality=80&w=400&h=400&crop=1"
            },

            new Artist
            {
                Id = 3,
                Name = "The Killers",
                Formed = 2001,
                Image = "https://media.pitchfork.com/photos/59299367c0084474cd0bead4/1:1/w_300/90179474.jpg"
            }
        };
    }
}