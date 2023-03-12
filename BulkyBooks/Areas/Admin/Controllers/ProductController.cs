
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
                productVM.product = _IUnitOfWork.Product.GetfirstOrDefault(u => u.Id == Id);
                return View(productVM);
            }            
            
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

                    if (obj.product.ImageUrl != null)
                    {
                        var oldImagePath = Path.Combine(wwwrootpath,obj.product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var filestrems = new FileStream(Path.Combine(Uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(filestrems);
                    }
                    obj.product.ImageUrl = @"\Images\Products\" + fileName + extension;
                }
                if (obj.product.Id == 0)
                {
                    _IUnitOfWork.Product.Add(obj.product);
                    TempData["success"] = "Product Created succesfully";
                }
                else
                {
                    _IUnitOfWork.Product.Update(obj.product);
                    TempData["success"] = "Product Updated succesfully";
                }
                _IUnitOfWork.Save();
               
                
            }
            else
            {
                return View("EditProduct", obj);
            }
            return RedirectToAction("Index");
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var Productlist = _IUnitOfWork.Product.Getall(includeProperties: "Category,CoverTypes");
            return Json(new { data= Productlist });
        }
        [HttpDelete]
        public IActionResult Delete(int? Id)
        {
            var obj = _IUnitOfWork.Product.GetfirstOrDefault(u => u.Id == Id);
            if (obj == null)
            {
                return Json(new { success=false,message="error while deleteing"});
            }
            if (obj.ImageUrl != null)
            {
                var oldImagePath = Path.Combine(_hostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _IUnitOfWork.Product.Remove(obj);
            _IUnitOfWork.Save();
            return Json(new { success = true , message = "delete successfull" });

        }
        #endregion

    }

}
