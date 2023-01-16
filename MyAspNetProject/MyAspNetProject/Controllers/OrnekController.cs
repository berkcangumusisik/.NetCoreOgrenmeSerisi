using Microsoft.AspNetCore.Mvc;

namespace MyAspNetProject.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

/*
 * Controller'da Action Metotları bulunur. 
 *
 */