
using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooks.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public CategoryController(IUnitOfWork IUnitOfWork)
        {
            _IUnitOfWork = IUnitOfWork; 

        }

        public IActionResult Index()
        {
            IEnumerable<Category> obj = _IUnitOfWork.Category.Getall();
            return View(obj);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.Category.Add(obj);
                _IUnitOfWork.Save();
               
                TempData["success"] = "Category added succesfully";
            }
            else
            {
                return View("CreateCategory", obj);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var categorydata = _IUnitOfWork.Category.GetfirstOrDefault(u=>u.Id==Id);
             

            if (categorydata == null)
            {
                return NotFound();
            }
            return View(categorydata);
        }

        [HttpPost]
        public IActionResult EditCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.Category.Update(obj);
                _IUnitOfWork.Save();
               
                TempData["success"] = "Category updated succesfully";
            }
            else
            {
                return View("EditCategory", obj);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCategory(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var categorydata = _IUnitOfWork.Category.GetfirstOrDefault(u=>u.Id== Id); 

            if (categorydata == null)
            {
                return NotFound();
            }
            return View(categorydata);
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.Category.Remove(obj);
                _IUnitOfWork.Save();
                TempData["success"] = "Category deleted succesfully";
            }
            else
            {
                return View("DeleteCategory", obj);
            }
            return RedirectToAction("Index");
        }

    }
}
