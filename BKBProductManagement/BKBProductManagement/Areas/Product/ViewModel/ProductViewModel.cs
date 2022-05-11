using System.Collections.Generic;

namespace BKBProductManagement.Areas.Product.ViewModel
{
    public class ProductViewModel
    {
        public List<BKBProductManagement.Models.Product> Products { get; set; }
        public BKBProductManagement.Models.Product Product { get; set; }

        public ProductViewModel()
        {

        }
    }
}