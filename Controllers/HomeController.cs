using Microsoft.AspNetCore.Mvc;

namespace FileServer.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index Test Page";
        }
    }
}
