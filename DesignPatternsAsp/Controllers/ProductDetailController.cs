using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;
using Tools.Earn.Class;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //Factories
            CLocalEarnFactory localEarnFactory = new CLocalEarnFactory(0.20m);
            CForeignEarnFactory foreignEarnFactory = new CForeignEarnFactory(3.30m, 20);

            //Products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
