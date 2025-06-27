using Microsoft.AspNetCore.Mvc;
using Duannoithat.Models;

namespace Duannoithat.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Liên hệ của bạn đã được gửi thành công!";
                ModelState.Clear(); 
            }

            return View();
        }
    }
}
