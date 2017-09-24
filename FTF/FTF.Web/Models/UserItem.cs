using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTF.Web.Models
{
    public class UserItem
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string Text { get; set; }
        public int Quadrant { get; set; }
    }
}