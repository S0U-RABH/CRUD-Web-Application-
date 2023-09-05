using Microsoft.AspNetCore.Mvc;

namespace Library_Api.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
