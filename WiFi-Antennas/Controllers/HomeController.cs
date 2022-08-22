using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WiFi_Antennas.BLL.Interfaces;
using WiFi_Antennas.BLL.Infrastructure;
using WiFi_Antennas.Models;
using WiFi_Antennas.Mappers;
using Microsoft.EntityFrameworkCore;

namespace WiFi_Antennas.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAntennaService _antennaService;

        public HomeController(ILogger<HomeController> logger, IAntennaService antennaService)
        {
            _logger = logger;
            _antennaService = antennaService;
        }

        public async Task<IActionResult> Index()
        {
            List<AntennaViewModel> antennas = (await _antennaService.GetAntennas(5, 0))
                .Select(a => a.ToViewModel())
                .ToList();
            return View(antennas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AntennaViewModel antenna)
        {
            try
            {
                _antennaService.Create(antenna.ToDTO());
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorViewModel error)
        {
            return View(error);
        }
    }
}