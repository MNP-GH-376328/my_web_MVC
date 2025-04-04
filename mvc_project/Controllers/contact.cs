using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class contact : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
