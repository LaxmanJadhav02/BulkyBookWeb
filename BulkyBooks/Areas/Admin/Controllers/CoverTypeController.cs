
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
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public CoverTypeController(IUnitOfWork IUnitOfWork)
        {
            _IUnitOfWork = IUnitOfWork; 

        }

        public IActionResult Index()
        {
            IEnumerable<CoverType> obj = _IUnitOfWork.CoverType.Getall();
            return View(obj);
        }
        [HttpGet]
        public IActionResult CreateCoverType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostCoverType(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.CoverType.Add(obj);
                _IUnitOfWork.Save();
               
                TempData["success"] = "CoverType added succesfully";
            }
            else
            {
                return View("CreateCoverType", obj);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCoverType(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var CoverTypedata = _IUnitOfWork.CoverType.GetfirstOrDefault(u=>u.Id==Id);
             

            if (CoverTypedata == null)
            {
                return NotFound();
            }
            return View(CoverTypedata);
        }

        [HttpPost]
        public IActionResult EditCoverType(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.CoverType.Update(obj);
                _IUnitOfWork.Save();
               
                TempData["success"] = "CoverType updated succesfully";
            }
            else
            {
                return View("EditCoverType", obj);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCoverType(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var CoverTypedata = _IUnitOfWork.CoverType.GetfirstOrDefault(u=>u.Id== Id); 

            if (CoverTypedata == null)
            {
                return NotFound();
            }
            return View(CoverTypedata);
        }

        [HttpPost]
        public IActionResult DeleteCoverType(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _IUnitOfWork.CoverType.Remove(obj);
                _IUnitOfWork.Save();
                TempData["success"] = "CoverType deleted succesfully";
            }
            else
            {
                return View("DeleteCoverType", obj);
            }
            return RedirectToAction("Index");
        }

    }
}
