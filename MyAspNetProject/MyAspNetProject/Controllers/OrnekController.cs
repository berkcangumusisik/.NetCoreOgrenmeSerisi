using Microsoft.AspNetCore.Mvc;

namespace MyAspNetProject.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Asp.Net Core";
            ViewData["age"] = 24;
            ViewData["names"] = new List<string> { "Ali", "Veli", "Ayşe" };
            ViewBag.person = new  { Id = 1, Name = "Ali", Age = 24 };
            TempData["message"] = "Merhaba Dünya";
            return View();
        }

        public IActionResult Index2()
        {
            var msg = TempData["message"];
            return View();
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("Index", "Ornek", new { id = id });
        }
        public IActionResult JsonResultParametreli(int id)
        {
            return Json(new { Id = id });

        }
        public IActionResult ContentResult()
        {
            return Content("Merhaba Dünya");
        }
        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, Name = "Kalem", price = "100" });

        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}

/*
 * Controller'da Action Metotları bulunur. 
 Action Results
* ActionResult => ActionResult sınıfı, bir Controller sınıfının Action Metotlarından döndürülebilecek tüm veri türlerini temsil eder.
* ContenResult => MVC projelerinde kullanıcılara dosya içeriklerini göstermemizi sağlayan veya yüklü olan dosyaları indirmelerini sağlayan metot tipidir.
* JsonResult => JSON(JavaScript Object Notation) veri yapısında geri döndürmemizi sağlayan bir tiptir.
* EmptyResult => Geriye bir şey döndürmeyen bir ActionResult tipidir.
* RedirectToAction("ViewName","Controller") =>RedirectToAction metodunu kullanarak yönlendirme işlemlerini gerçekleştirir.

 Veri Taşıma Yöntemleri
- ViewBag. => ViewBag. yöntemi ile Controller sınıfından View'a veri taşıma işlemini gerçekleştirebiliriz.
- ViewData => ViewData yöntemi ile Controller sınıfından View'a veri taşıma işlemini gerçekleştirebiliriz.
ViewData["age"] = 24;
- TempData => TempData yöntemi ile Controller sınıfından View'a veri taşıma işlemini gerçekleştirebiliriz. Bir Action Metotundan diğer Action Metotuna veri taşımak için kullanılır.

 */


/*
Razor Syntax
- Html içerisinde C# kodu yazabilmemizi sağlayan bir yapıdır.
- Html içinde C# kodunu @ işareti ile başlatırız.
- @{ } bloğu içerisinde birden fazla satırda C# kodu yazabiliriz.
- @: ifadesi ile Html içerisinde C# kodu yazabiliriz.

 
 */

/*
 * Bir layoutta genel olarak header, footer, menü gibi alanlar aynıdır. Bu alanları layoutta tanımlayıp, diğer viewlarda kullanabiliriz.
 * Content alanı ise her viewda farklıdır. Bu alanı layoutta tanımlamayıp, viewlarda tanımlayabiliriz. 
 * @RenderBody() => Content alanını temsil eder. 
 * Birden fazla layout kullanmak bulunabilir. 
 */