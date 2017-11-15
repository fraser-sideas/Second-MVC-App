using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Second_MVC_App.Models;

namespace Second_MVC_App.ViewModels
{
    public class RandomAlbumViewModel
    {
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
    }
}