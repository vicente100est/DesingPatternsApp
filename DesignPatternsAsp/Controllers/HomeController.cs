using DesignPatterns.Models.Data;
using DesignPatterns.Repository.Interface;
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

        private readonly IRepository<Beer> _repository;

        public HomeController(IOptions<CMyConfig> config,
            IRepository<Beer> repository)
        {
            this._config = config;
            this._repository = repository;
        }

        public IActionResult Index()
        {
            CLog.GetInstance(_config.Value.PathLog).Save("Entro a index");

            IEnumerable<Beer> lst = _repository.Get();

            return View("Index", lst);
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
