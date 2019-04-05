using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickKartCoreMVCApp.Controllers
{
    public class AdminController : Controller
    {

        // GET: /<controller>/
        public IActionResult AdminHome()
        {
            List<string> lstProducts = new List<string>();
            lstProducts.Add("See and Say");
            lstProducts.Add("Wall Stickers");
            lstProducts.Add("Curtains");
            ViewBag.TopProducts = lstProducts;
            return View();


        }
    }
}
