using System.Web.Mvc;

namespace BKBProductManagement.Areas.Product
{
    public class ProductAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Product";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Product_default",
                "Product/{controller}/{action}",
                new { action = "Index" },
                new string[] { "BKBProductManagement.Areas.Product.Controllers" }
            );
        }
    }
}