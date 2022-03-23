using Microsoft.AspNetCore.Mvc;

namespace FileServer.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
