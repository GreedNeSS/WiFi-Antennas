using Microsoft.AspNetCore.Mvc;

namespace WiFi_Antennas.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Channels()
        {
            return View();
        }
    }
}
