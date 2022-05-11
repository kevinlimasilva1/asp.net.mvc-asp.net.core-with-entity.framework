using BKBProductManagement.Areas.Supplier.ViewModel;
using BKBProductManagement.Service;
using System;
using System.Web.Mvc;

namespace BKBProductManagement.Areas.Supplier.Controllers
{
    public class NewSupplierController : Controller
    {
        public ServiceTest _service { get; set; }
        public NewSupplierController()
        {
            _service = new ServiceTest();
        }

        public ActionResult Index()
        {
            var vm = new NewSupplierViewModel() { ViewAction = "Get" };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(BKBProductManagement.Models.Supplier supplier)
        {
            var vm = new NewSupplierViewModel() { ViewAction = "Post", ActionMessage = "Fornecedor cadastrado com sucesso!" };
            try
            {
                supplier.Date = DateTime.Now;
                supplier.DateR = DateTime.Now;
                var newProduct = _service.PostSupplier(supplier);
            }
            catch (System.Exception ex)
            {
                vm.ActionMessage = ex.Message;
            }

            return View(vm);
        }
    }
}