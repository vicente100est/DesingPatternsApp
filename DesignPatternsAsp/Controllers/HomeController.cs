using DesignPatternsAsp.Configuration;
using DesignPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace DesignPatternsAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<CMyConfig> _config;
        public HomeController(IOptions<CMyConfig> config)
        {
            this._config = config;
        }

        public IActionResult Index()
        {
            CLog.GetInstance(_config.Value.PathLog).Save("Entro a index");
            return View();
        }

        public IActionResult Privacy()
        {
            CLog.GetInstance(_config.Value.PathLog).Save("Entro a privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
