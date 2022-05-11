using BKBProductManagement.Areas.Supplier.ViewModel;
using BKBProductManagement.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BKBProductManagement.Areas.Supplier.Controllers
{
    public class SupplierController : Controller
    {
        public ServiceTest _service { get; set; }
        public SupplierController()
        {
            _service = new ServiceTest();
        }

        public async Task<ActionResult> Index()
        {
            var suppliers = await _service.GetAllSuppliers();
            var vm = new SupplierViewModel()
            {
                Suppliers = suppliers
            };

            return View(vm);
        }

        public async Task<ActionResult> Edit(int supplierId)
        {
            var supplier = await _service.GetSupplierById(supplierId);
            var vm = new SupplierViewModel()
            {
                Supplier = supplier
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(BKBProductManagement.Models.Supplier supplier)
        {
            var response = await _service.EditSupplier(supplier);
            var vm = new SupplierViewModel()
            {
                Supplier = response
            };

            return View(vm);
        }

        public async Task<ActionResult> Delete(int supplierId)
        {
            var result = await _service.DeleteSupplierById(supplierId);
            return Json(new { responseStatus = result }, JsonRequestBehavior.AllowGet);
        }
    }
}