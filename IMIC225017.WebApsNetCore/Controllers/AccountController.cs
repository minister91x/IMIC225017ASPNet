using IMIC225017.WebApsNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMIC225017.WebApsNetCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AccountLogIn([FromBody] AccountLogInModels model)
        {
            // xử lý gọi DB đăng nhập

            HttpContext.Session.SetString("UserName", model.UserName ?? string.Empty);
            return Json(new { ResponseCode = 1, des = "Đăng nhập thành công!" });

        }
    }
}
