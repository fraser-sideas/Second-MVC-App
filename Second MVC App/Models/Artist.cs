using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Second_MVC_App.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Formed { get; set; }
        public string Image { get; set; }
    }
}