using Microsoft.AspNetCore.Mvc;

namespace UnBoredV2.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
