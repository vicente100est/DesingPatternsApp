using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;
using Tools.Earn.Class;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private CEarnFactory _localEarnFactory;
        private CForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(CLocalEarnFactory localEarnFactory,
            CForeignEarnFactory foreignEarnFactory)
        {
            this._localEarnFactory = localEarnFactory;
            this._foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            //Products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
