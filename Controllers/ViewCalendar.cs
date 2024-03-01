using Microsoft.AspNetCore.Mvc;

namespace ZencareLTE.Controllers
{
    public class ViewCalendar : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult CalendarView()
        {
            return View();
        }
    }
}
