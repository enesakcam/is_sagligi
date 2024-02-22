using Microsoft.AspNetCore.Mvc;

namespace enes482.Controllers
{
    public class listeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("liste/marka/{id}/{ad}")]
        public string marka(int id, string ad)
        {
            return $"Parametreden gelen id={id}, ad={ad}";
        }
    }
}
