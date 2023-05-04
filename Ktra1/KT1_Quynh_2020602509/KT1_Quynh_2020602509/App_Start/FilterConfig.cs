using System.Web;
using System.Web.Mvc;

namespace KT1_Quynh_2020602509
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
