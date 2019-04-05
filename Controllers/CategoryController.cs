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
    public class CategoryController : Controller
    {
        private readonly QuickKartContext _context;
        QuickKartRepository repObj;
       
        private readonly IMapper _mapper;

        public CategoryController(QuickKartContext context, IMapper mapper)
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

        public IActionResult ViewCategories()
        {
            var lstEntityCategories = repObj.GetCategories();
            List<Models.Categories> lstModelCategories = new List<Models.Categories>();
            foreach (var category in lstEntityCategories)
            {
                lstModelCategories.Add(_mapper.Map<Models.Categories>(category));
            }
            return View(lstModelCategories);
        }

        public IActionResult AddCategory()
        {
            string categoryId = repObj.GetNextCategoryId();
            ViewBag.NextCategoryId = categoryId;
            return View();
        }

        [HttpPost]
        public IActionResult SaveAddedCategory(Models.Categories category)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    status = repObj.AddCategory(_mapper.Map<Categories>(category));
                    if (status)
                        return RedirectToAction("ViewCategories");
                    else
                        return View("Error");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("AddCategory", category);
        }

        public IActionResult UpdateCategory(Models.Categories catObj)
        {
            return View(catObj);
        }

        [HttpPost]
        public IActionResult SaveUpdatedCategory(Models.Categories category)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    status = repObj.UpdateCategory(_mapper.Map<Categories>(category));
                    if (status)
                        return RedirectToAction("ViewCategories");
                    else
                        return View("Error");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("UpdateCategory", category);
        }

        public IActionResult DeleteCategory(Models.Categories category)
        {
            return View(category);
        }

        [HttpPost]
        public IActionResult SaveDeletion(string categoryId)
        {
            bool status = false;
            try
            {

                //string productId = null;
                status = repObj.DeleteCategory(_mapper.Map<Categories>(categoryId));
                if (status)
                    return RedirectToAction("ViewCategories");
                else
                    return View("Error");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }







    }
}
