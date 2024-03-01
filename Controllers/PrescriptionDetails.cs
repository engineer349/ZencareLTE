using Microsoft.AspNetCore.Mvc;

namespace ZencareLTE.Controllers
{
    public class PrescriptionDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
