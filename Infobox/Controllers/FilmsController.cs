using System.Linq;
using System.Web.Mvc;
using Infobox.Models;
using Infobox.ViewModels;

namespace Infobox.Controllers
{
    public class FilmsController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DBContext())
            {
                return View(context.Films.ToList());
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            using (var context = new DBContext())
            {
                return View(new FilmViewModel
                {
                    AvaliableGenres = new MySelectList(context.Genres.ToList(), "Id", "Title")
                });
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(FilmViewModel film)
        {
            using (var context = new DBContext())
            {
                return RedirectToAction("Index");
            }
        }
    }
}
