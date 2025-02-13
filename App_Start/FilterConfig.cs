using System.Web;
using System.Web.Mvc;

namespace Paymeny_Gateway_Integration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
