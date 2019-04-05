using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickKartDataAccessLayer.Models;
using QuickKartDataAccessLayer;
using AutoMapper;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickKartCoreMVCApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly QuickKartContext _context;
        QuickKartRepository repObj;
        private readonly IMapper _mapper;

        public ProductController(QuickKartContext context, IMapper mapper)
        {
            _context = context;
            repObj = new QuickKartRepository(_context);
            _mapper = mapper;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewProducts()
        {
            var lstEntityProducts = repObj.GetProducts();
            List<Models.Products> lstModelProducts = new List<Models.Products>();
            foreach (var product in lstEntityProducts)
            {
                lstModelProducts.Add(_mapper.Map<Models.Products>(product));
            }
            return View(lstModelProducts);
        }

        public IActionResult AddProduct()
        {
            string productId = repObj.GetNextProductId();
            ViewBag.NextProductId = productId;
            return View();
        }

        [HttpPost]
        public IActionResult SaveAddedProduct(Models.Products product)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    status = repObj.AddProduct(_mapper.Map<Products>(product));
                    if (status)
                        return RedirectToAction("ViewProducts");
                    else
                        return View("Error");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("AddProduct", product);
        }

        public IActionResult UpdateProduct(Models.Products prodObj)
        {
            return View(prodObj);
        }
        [HttpPost]
        public IActionResult SaveUpdatedProduct(Models.Products product)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    status = repObj.UpdateProduct(_mapper.Map<Products>(product));
                    if (status)
                        return RedirectToAction("ViewProducts");
                    else
                        return View("Error");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("UpdateProduct", product);
        }

        public IActionResult DeleteProduct(Models.Products product)
        {
            return View(product);
        }

        [HttpPost]
        public IActionResult SaveDeletion(string productId)
        {
            bool status = false;
            try
            {
                status = repObj.DeleteProduct(productId);
                if (status)
                    return RedirectToAction("ViewProducts");
                else
                    return View("Error");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public IActionResult GetProductForCategory(byte? categoryId)
        {
            ViewBag.CategoryList = repObj.GetCategories();
            var productList = repObj.GetProducts();
            var products = new List<Models.Products>();
            foreach (var product in productList)
            {
                products.Add(_mapper.Map<Models.Products>(product));
            }
            var filteredProducts = products.Where(model => model.CategoryId == categoryId);
            return View(filteredProducts);
        }


    }
}













