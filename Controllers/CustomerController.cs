using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickKartCoreMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult CustomerHome()
        {
            List<string> lstProducts = new List<string>();
            lstProducts.Add("Dell Inspiron");
            lstProducts.Add("Marble chess board");
            lstProducts.Add("Adidas shoes");
            ViewBag.TopProducts = lstProducts;
            return View();
        }
    }
}
