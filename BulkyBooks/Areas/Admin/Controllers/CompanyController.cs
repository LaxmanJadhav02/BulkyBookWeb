
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
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        public CompanyController(IUnitOfWork IUnitOfWork,IWebHostEnvironment webHostEnvironment)
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
            Company Company = new();
            
            
            if (Id == null || Id == 0)
            {
               
                return View(Company);
            }
            else {
                //update Company
                Company = _IUnitOfWork.Company.GetfirstOrDefault(u => u.Id == Id);
                return View(Company);
            }            
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company obj)
        {
            if (ModelState.IsValid)
            {
                
                if (obj.Id == 0)
                {
                    _IUnitOfWork.Company.Add(obj);
                    TempData["success"] = "Company Created succesfully";
                }
                else
                {
                    _IUnitOfWork.Company.Update(obj);
                    TempData["success"] = "Company Updated succesfully";
                }
                _IUnitOfWork.Save();
               
                
            }
            else
            {
                return View("EditCompany", obj);
            }
            return RedirectToAction("Index");
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var Companylist = _IUnitOfWork.Company.Getall();
            return Json(new { data= Companylist });
        }
        [HttpDelete]
        public IActionResult Delete(int? Id)
        {
            var obj = _IUnitOfWork.Company.GetfirstOrDefault(u => u.Id == Id);
            if (obj == null)
            {
                return Json(new { success=false,message="error while deleteing"});
            }
            
            _IUnitOfWork.Company.Remove(obj);
            _IUnitOfWork.Save();
            return Json(new { success = true , message = "delete successfull" });

        }
        #endregion

    }

}
