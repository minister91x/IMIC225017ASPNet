using System.Diagnostics;
using System.Security.Permissions;
using IMIC225017.CommonNetCore;
using IMIC225017.DataAccessNetCore.DataObject;
using IMIC225017.DataAccessNetCore.IRespository;
using IMIC225017.WebApsNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMIC225017.WebApsNetCore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Index(int? id)
        {
            try
            {
                // bước 1 :đi tìm thư mục views
                // bước 2: đi tìm thư mục có tên giống tên của Controller( Home) trong thư mục views
                // bước 3: đi tìm file có tên trùng tên của Action (Index) trong thư mục Home
                return View();
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost()]
        public async Task<IActionResult> _ListProductPartialViews([FromBody] ProductGetListRequestData requestData)
        {
            var list = new List<Product>();
            try
            {
                list = await _productRepository.ProductGetList(requestData);

            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView(list);
        }


        [HttpPost]
        public async Task<IActionResult> ProductInsert([FromBody] Product model)
        {

            try
            {
                if (model == null)
                {
                    return Json(new { ResponseCode = 1, des = "Tên sản phẩm không được trống \"" });
                }

                if (string.IsNullOrEmpty(model.ProductName))
                {
                    return Json(new { ResponseCode = 1, des = "Tên sản phẩm không được trống \"" });
                }

                if (!Sercurity.CheckXSSInput(model.ProductName))
                {
                    return Json(new { ResponseCode = 1, des = "Tên sản phẩm không hợp lệ\"" });
                }

                if (string.IsNullOrEmpty(model.Description))
                {
                    return Json(new { ResponseCode = 1, des = "Description sản phẩm không được trống" });
                }
                if (!Sercurity.CheckSpecicalCharacter(model.Description))
                {
                    return Json(new { ResponseCode = 1, des = "Description sản phẩm không hợp lệ!" });
                }

                if (model.ProductID <= 0)
                {
                    //Insert

                    var result = await _productRepository.ProductInsert(model);
                    if (result > 0)
                    {
                        return Json(new { ResponseCode = 1, des = "Insert Thành công!" });
                    }
                    else
                    {
                        switch (result)
                        {
                            case -1: return Json(new { ResponseCode = 1, des = "Sản phầm đã tồn tại" });
                            default: return Json(new { ResponseCode = 1, des = "Insert thất bại!" });
                        }

                    }
                }
                else
                {
                    // Update

                    var result = await _productRepository.ProductUpdate(model);
                    if (result > 0)
                    {
                        return Json(new { ResponseCode = 1, des = "Update Thành công!" });
                    }
                    else
                    {
                        switch (result)
                        {
                            case -1: return Json(new { ResponseCode = 1, des = "Sản phầm đã tồn tại" });
                            default: return Json(new { ResponseCode = 1, des = "Insert thất bại!" });
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                return Json(new { ResponseCode = 1, des = ex.Message });
            }
        }


        public async Task<IActionResult> Product_Delete([FromBody] Product_Delete model)
        {
            try
            {
                var result = await _productRepository.Product_Delete(model.ProductID);
                if (result > 0)
                {
                    return Json(new { ResponseCode = 1, des = "xóa Thành công!" });
                }
                else
                {
                    switch (result)
                    {
                        case -1: return Json(new { ResponseCode = 1, des = "Sản phầm đã tồn tại" });
                        default: return Json(new { ResponseCode = 1, des = "Insert thất bại!" });
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ActionResult> ProductInsertUpdate(int? Id)
        {
            if (Id.HasValue && Id.Value > 0)
            {
                var product = await _productRepository.ProductGetById(Id.Value);
                if (product != null)
                {
                    return View(product);
                }
            }
            else
            {
                return View(new Product());
            }
            return View();
        }


        [HttpPost()]
        public async Task<IActionResult> Index(Product model)
        {
            var des = string.Empty;
            try
            {

                if (model == null)
                {
                    des = "Tên sản phẩm không được trống";
                    ViewBag.Desc = des;
                    return View();
                }

                if (string.IsNullOrEmpty(model.ProductName))
                {
                    des = "Tên sản phẩm không được trống";
                    ViewBag.Desc = des;
                    return View();
                }

                if (!Sercurity.CheckXSSInput(model.ProductName))
                {
                    des = "Tên sản phẩm không hợp lệ";
                    ViewBag.Desc = des;
                    return View();
                }


                if (string.IsNullOrEmpty(model.Description))
                {
                    des = "Description sản phẩm không được trống";
                    ViewBag.Desc = des;
                    return View();
                }
                if (!Sercurity.CheckSpecicalCharacter(model.Description))
                {
                    des = "Description sản phẩm không hợp lệ";
                    ViewBag.Desc = des;
                    return View();
                }

                var result = await _productRepository.ProductInsert(model);
                if (result > 0) { des = "Insert thành công"; }
                else
                {
                    des = "Insert thất bại";
                }
                ViewBag.Desc = des;
                var requestData = new IMIC225017.DataAccessNetCore.DataObject.ProductGetListRequestData
                {
                    ColorID = 0,
                    PageIndex = 1,
                    PageSize = 10,
                    PriceFrom = 0,
                    PriceTo = 0,
                    ProductName = string.Empty,
                    SizeID = 0

                };
                var list = await _productRepository.ProductGetList(requestData);

                return View(list);

            }
            catch (Exception ex)
            {

                throw;
            }



            return View();
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
