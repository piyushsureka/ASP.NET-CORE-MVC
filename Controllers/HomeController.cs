using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickKartCoreMVCApp.Models;
using Microsoft.AspNetCore.Http;
using QuickKartDataAccessLayer;
using QuickKartDataAccessLayer.Models;

namespace QuickKartCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuickKartContext _context;
        QuickKartRepository repObj;
        public HomeController(QuickKartContext context)
        {
            _context = context;
            repObj = new QuickKartRepository(_context);
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CheckRole(IFormCollection frm)
        {
            string userId = frm["name"];
            string password = frm["pwd"];
            string checkbox = frm["RememberMe"];
            string lastLogin = Convert.ToString(DateTime.Now);
         
          
            if (checkbox == "on")
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(1);
                
                
                Response.Cookies.Append("UserId", userId, option);
                Response.Cookies.Append("Password", password, option);
                Response.Cookies.Append("LastLogin", lastLogin, option);
                HttpContext.Session.SetString("LastLogin", lastLogin);
            }

            string username = userId.Split('@')[0];

            byte? roleId = repObj.ValidateCredentials(userId, password);
            if (roleId == 1)
            {
                HttpContext.Session.SetString("username", username);
                

                return Redirect("/Admin/AdminHome?username=" + username);
                
            }
            else if (roleId == 2)
            {
                HttpContext.Session.SetString("Customer_userId", userId);

                return Redirect("/Customer/CustomerHome?username=" + username);
            }
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetCoupons()
        {
            Random random = new Random();
            Dictionary<string, string> data = new Dictionary<string, string>();
            string[] value = new String[5];
            string[] key = { "Arts", "Electronics", "Fashion", "Home", "Toys" };
            for (int i = 0; i < 5; i++)
            {
                string number = "RUSH" + random.Next(1, 10).ToString() + random.Next(1, 10).ToString() + random.Next(1, 10).ToString();
                value[i] = number;
            }
            for (int i = 0; i < 5; i++)
            {
                data.Add(key[i], value[i]);
            }
            return Json(data);
        }

        public ViewResult Contact()
        {
            return View();
        }

        public RedirectResult FAQ()
        {
            return Redirect("/Home/Contact");
        }

        public IActionResult RegisterUser()
        {
            return View();
        }
        public RedirectResult Logout()
        {
            return Redirect("/Home/Contact");
        }
    }
}
