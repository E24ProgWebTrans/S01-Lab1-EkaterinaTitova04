using Microsoft.AspNetCore.Mvc;

namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
