
using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
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

        public IActionResult Details(int productId)
        {
            ShoppingCart shoppingCart = new ShoppingCart()
            {
                Product = _IUnitOfWork.Product.GetfirstOrDefault(u => u.Id == productId, includeProperties: "Category,CoverTypes"),
                Count =1,
                ProductId= productId
            };
            return View(shoppingCart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity =(ClaimsIdentity) User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            shoppingCart.ApplicationUserId = claim.Value;

            ShoppingCart cart = _IUnitOfWork.ShoppingCart.GetfirstOrDefault(u=>u.ApplicationUserId==claim.Value && u.ProductId==shoppingCart.ProductId);

            if (cart == null)
            {
                _IUnitOfWork.ShoppingCart.Add(shoppingCart);
            }
            else {
                _IUnitOfWork.ShoppingCart.IncrementCount(cart, shoppingCart.Count);
            }
            
            _IUnitOfWork.Save();
            return RedirectToAction(nameof(Index));
            
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
