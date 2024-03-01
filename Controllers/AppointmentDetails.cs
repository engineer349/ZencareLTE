using Microsoft.AspNetCore.Mvc;

namespace ZencareLTE.Controllers
{
    public class AppointmentDetails : Controller
    {

        public IActionResult Create()
        {
            return View();
        }
    }
}
