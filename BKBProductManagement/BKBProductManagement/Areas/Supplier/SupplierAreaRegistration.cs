using System.Web.Mvc;

namespace BKBProductManagement.Areas.Supplier
{
    public class SupplierAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Supplier";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Supplier_default",
                "Supplier/{controller}/{action}",
                new { action = "Index" },
                new string[] { "BKBProductManagement.Areas.Supplier.Controllers" }
            );
        }
    }
}