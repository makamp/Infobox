using System.Linq;
using System.Web.Mvc;
using Infobox.Models;

namespace Infobox.Controllers
{
    public class GenresController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DBContext())
            {
                return View(context.Genres.ToList());
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new Genre());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Genre genre)
        {
            using (var context = new DBContext())
            {
                context.Genres.Add(genre);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            using (var context = new DBContext())
            {
                return View(context.Genres.FirstOrDefault(g => g.Id == id));
            }
        }
    }
}
