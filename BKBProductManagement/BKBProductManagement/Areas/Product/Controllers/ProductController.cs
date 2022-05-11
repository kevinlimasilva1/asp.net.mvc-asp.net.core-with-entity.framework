using BKBProductManagement.Areas.Product.ViewModel;
using BKBProductManagement.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BKBProductManagement.Areas.Product.Controllers
{
    public class ProductController : Controller
    {
        public ServiceTest _service { get; set; }
        public ProductController()
        {
            _service = new ServiceTest();
        }

        public async Task<ActionResult> Index()
        {
            var products = await _service.GetAllProducts();
            var vm = new ProductViewModel() {
                Products = products
            };

            return View(vm);
        }

        public async Task<ActionResult> Edit(int productId)
        {
            var product = await _service.GetProductById(productId);
            var vm = new ProductViewModel()
            {
                Product = product
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(BKBProductManagement.Models.Product product)
        {
            var response = await _service.EditProduct(product);
            var vm = new ProductViewModel()
            {
                Product = response
            };

            return View(vm);
        }

        public async Task<ActionResult> Delete(int productId)
        {
            var result = await _service.DeleteProductById(productId);
            return Json(new { responseStatus = result }, JsonRequestBehavior.AllowGet);
        }
    }
}