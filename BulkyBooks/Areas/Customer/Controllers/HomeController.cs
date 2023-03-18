
using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace BulkyBooks.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _IUnitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork IUnitOfWork)
        {
            _logger = logger;
            _IUnitOfWork = IUnitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> obj = _IUnitOfWork.Product.Getall(includeProperties: "Category,CoverTypes");
            return View(obj);
        }

        public IActionResult Details(int id)
        {
            ShoppingCart shoppingCart = new ShoppingCart()
            {
                Product = _IUnitOfWork.Product.GetfirstOrDefault(u => u.Id == id, includeProperties: "Category,CoverTypes"),
                Count =1
            };
            return View(shoppingCart);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
