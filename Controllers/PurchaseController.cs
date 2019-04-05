using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickKartCoreMVCApp;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using QuickKartDataAccessLayer;
using QuickKartDataAccessLayer.Models;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickKartCoreMVCApp.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly QuickKartContext _context;
        QuickKartRepository repObj;
        private readonly IMapper _mapper;
        public PurchaseController(QuickKartContext context, IMapper mapper)
        {
            _context = context;
            repObj = new QuickKartRepository(_context);
            _mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult PurchaseProduct(Models.Products productObj)
        {
            Models.PurchaseDetails purchaseObj = new Models.PurchaseDetails();
            purchaseObj.EmailId = HttpContext.Session.GetString("Customer_userId").ToString();
            purchaseObj.ProductId = productObj.ProductId;
            purchaseObj.DateOfPurchase = DateTime.Now;
            TempData["ProductName"] = productObj.ProductName;
            return View(purchaseObj);
        }



        [HttpPost]
        public ActionResult SavePurchase(Models.PurchaseDetails purchaseObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ViewData["QuantityPurchased"] = purchaseObj.QuantityPurchased;
                    var status = repObj.PurchaseProduct(_mapper.Map<PurchaseDetails>(purchaseObj));
                    if (status)
                        return View("Success");
                    else
                        return View("Error");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("PurchaseProduct", purchaseObj);
        }


    }
}
