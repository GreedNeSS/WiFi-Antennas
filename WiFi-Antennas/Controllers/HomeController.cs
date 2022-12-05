using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WiFi_Antennas.BLL.Interfaces;
using WiFi_Antennas.BLL.Infrastructure;
using WiFi_Antennas.Models;
using WiFi_Antennas.Mappers;
using Microsoft.EntityFrameworkCore;
using System;

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

        public async Task<IActionResult> Index(string ssid, string ip, string address,
            int page = 1, SortStateViewModel sortOrder = SortStateViewModel.IpAsc)
        {
            int pageSize = 5;
            int antennaCount = await _antennaService.GetCountAsync(ssid, ip, address);
            int skip = (page - 1) * pageSize;

            List<AntennaViewModel> antennas = (await _antennaService.GetAntennasAsync(pageSize, skip, ssid, ip, address, sortOrder.ToDTO()))
                .Select(a => a.ToViewModel())
                .ToList();

            return View(new IndexViewModel(antennas,
                new FilterViewModel { IpFiltering = ip, AddressFiltering = address, SSIDFiltering = ssid},
                new SortViewModel(sortOrder),
                new PageViewModel(antennaCount, page, pageSize)));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int antennaId)
        {
            try
            {
                AntennaViewModel? antenna = (await _antennaService.GetAntennaAsync(antennaId)).ToViewModel();
                return View(antenna);
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AntennaViewModel antenna)
        {
            try
            {
                await _antennaService.UpdateAsync(antenna.ToDTO());
                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AntennaViewModel antenna)
        {
            try
            {
                await _antennaService.CreateAsync(antenna.ToDTO());
                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _antennaService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                AntennaViewModel antenna = (await _antennaService.GetAntennaAsync(id)).ToViewModel();
                return View(antenna);
            }
            catch (ValidationException ex)
            {
                return View("Error", new ErrorViewModel(ex.Message, ex.Property));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorViewModel error)
        {
            return View(error);
        }
    }
}