using BKBProductManagement.Areas.Product.ViewModel;
using BKBProductManagement.Service;
using System;
using System.Web.Mvc;

namespace BKBProductManagement.Areas.Product.Controllers
{
    public class NewProductController : Controller
    {
        public ServiceTest _service { get; set; }
        public NewProductController()
        {
            _service = new ServiceTest();
        }

        public ActionResult Index()
        {
            var vm = new NewProductViewModel() { ViewAction = "Get" };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(BKBProductManagement.Models.Product product)
        {
            var vm = new NewProductViewModel(){ ViewAction = "Post", ActionMessage = "Produto cadastrado com sucesso!" };
            try
            {
                product.DateR = DateTime.Now;
                var newProduct = _service.PostProduct(product);
            }
            catch (System.Exception ex)
            {
                vm.ActionMessage = ex.Message;
            }

            return View(vm);
        }
    }
}