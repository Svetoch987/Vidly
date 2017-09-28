using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin
        public ActionResult Index()
        {
            var adminNews = new AdminNews();

            return View("AdminNewsForm", adminNews);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(AdminNews adminNews)
        {
            if (adminNews.Id == 0)
            {
                _context.AdminNews.Add(adminNews);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}