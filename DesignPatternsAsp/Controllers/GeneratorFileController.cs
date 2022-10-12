using DesignPatterns.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tools.Generator.Class;

namespace DesignPatternsAsp.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork,
            GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            this._unitOfWork = unitOfWork;
            this._generatorConcreteBuilder = generatorConcreteBuilder;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(d => d.BeerName).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";

                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                else
                    generatorDirector.CreateSimplePiPEgENERATOR(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();

                return Json("Archivo Generado");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
