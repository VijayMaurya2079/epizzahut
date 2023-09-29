using ePizzaHub.Services.Interfaces;
using ePizzaHub.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace ePizzaHub.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IItemService _itemService;
        IMemoryCache _cache;
        public HomeController(ILogger<HomeController> logger, IItemService itemService, IMemoryCache cache)
        {
            _logger = logger;
            _itemService = itemService;
            _cache = cache;
        }
        public IActionResult Index()
        {
            //var items = _itemService.GetAll();
            string key = "catalog";
            var items = _cache.GetOrCreate(key, entry =>
            {
                entry.AbsoluteExpiration = DateTime.Now.AddHours(12);
                //entry.SlidingExpiration = TimeSpan.FromMinutes(15);

                return _itemService.GetAll();
            });

            //handled error
            try
            {
                int x = 0, y = 4;
                int z = y / x;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}