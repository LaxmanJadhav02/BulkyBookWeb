
using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooks.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductController(IUnitOfWork IUnitOfWork,IWebHostEnvironment webHostEnvironment)
        {
            _IUnitOfWork = IUnitOfWork;
            _hostEnvironment = webHostEnvironment;

        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int? Id)
        {
            ProductVM productVM = new()
            {
                product = new(),
                CategoryList = _IUnitOfWork.Category.Getall().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _IUnitOfWork.CoverType.Getall().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
               
            
            
            if (Id == null || Id == 0)
            {
               
                return View(productVM);
            }
            else { 
            //update product
            }            
            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM obj,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwrootpath = _hostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var Uploads = Path.Combine(wwwrootpath, @"Images\Products");
                    var extension = Path.GetExtension(file.FileName);
                    using (var filestrems = new FileStream(Path.Combine(Uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(filestrems);
                    }
                    obj.product.ImageUrl = @"\Images\Products\" + fileName + extension;
                }
                _IUnitOfWork.Product.Add(obj.product);
                _IUnitOfWork.Save();
               
                TempData["success"] = "Product Created succesfully";
            }
            else
            {
                return View("EditProduct", obj);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Productdata = _IUnitOfWork.Product.GetfirstOrDefault(u=>u.Id== Id); 

            if (Productdata == null)
            {
                return NotFound();
            }
            return View(Productdata);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.Product.Remove(obj);
                _IUnitOfWork.Save();
                TempData["success"] = "Product deleted succesfully";
            }
            else
            {
                return View("DeleteProduct", obj);
            }
            return RedirectToAction("Index");
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var Productlist = _IUnitOfWork.Product.Getall();
            return Json(new { data= Productlist });
        }
        #endregion

    }

}
