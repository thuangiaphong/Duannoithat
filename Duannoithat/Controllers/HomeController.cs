using System.Diagnostics;
using Duannoithat.Models;
using Duannoithat.Models.Interface;
using Duannoithat.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Duannoithat.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepositor)
        {
            this.productRepository = productRepositor;
        }

        public IActionResult Index()
        {
            var trendingProducts = productRepository.GetTrendingProducts();
            if (trendingProducts == null)
            {
                trendingProducts = new List<Product>(); // Trả về danh sách rỗng để View không bị lỗi NullReferenceException
            }
            return View(trendingProducts);
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
