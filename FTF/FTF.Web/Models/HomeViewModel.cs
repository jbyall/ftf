using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTF.Web.Models
{
    public class HomeViewModel
    {
        public List<UserItem> Quad1 { get; set; }
        public List<UserItem> Quad2 { get; set; }
        public List<UserItem> Quad3 { get; set; }
        public List<UserItem> Quad4 { get; set; }

    }
}