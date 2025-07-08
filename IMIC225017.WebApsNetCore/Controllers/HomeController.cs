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

        public async Task<IActionResult> Index(int? id )
        {
            try
            {
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


                // bước 1 :đi tìm thư mục views
                // bước 2: đi tìm thư mục có tên giống tên của Controller( Home) trong thư mục views
                // bước 3: đi tìm file có tên trùng tên của Action (Index) trong thư mục Home
                return View(list);
            }
            catch (Exception)
            {

                throw;
            }
           
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

                if(!Sercurity.CheckXSSInput(model.ProductName))
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

                var result= await _productRepository.ProductInsert(model);
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
