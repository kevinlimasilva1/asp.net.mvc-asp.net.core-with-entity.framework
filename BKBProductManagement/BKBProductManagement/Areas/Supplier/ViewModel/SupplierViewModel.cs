using System.Collections.Generic;

namespace BKBProductManagement.Areas.Supplier.ViewModel
{
    public class SupplierViewModel
    {
        public List<BKBProductManagement.Models.Supplier> Suppliers { get; set; }
        public BKBProductManagement.Models.Supplier Supplier { get; set; }

        public SupplierViewModel()
        {

        }
    }
}