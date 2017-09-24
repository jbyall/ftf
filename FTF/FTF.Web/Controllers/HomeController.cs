using FTF.Web.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FTF.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<ActionResult> Index()
        {
            var sessionUser = (ClaimsIdentity)this.User.Identity;
            var dbUser = await UserManager.FindByEmailAsync(sessionUser.Name);
            var items = new List<UserItem>
            {
                new UserItem{ UserId = dbUser.Id, Text = "Do a bunch of stuff quad 1.", Quadrant=1 },
                new UserItem{ UserId = dbUser.Id, Text = "Do more stuff quad 2.", Quadrant=2 },
                new UserItem{ UserId = dbUser.Id, Text = "Do more stuff quad 3.", Quadrant=3 },
                new UserItem{ UserId = dbUser.Id, Text = "Do more stuff quad 4.", Quadrant=4 },
            };
            var model = new HomeViewModel();
            model.Quad1 = items.Where(i => i.Quadrant == 1).ToList();
            model.Quad2 = items.Where(i => i.Quadrant == 2).ToList();
            model.Quad3 = items.Where(i => i.Quadrant == 3).ToList();
            model.Quad4 = items.Where(i => i.Quadrant == 4).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}