using System.Web;
using System.Web.Mvc;

namespace NguyenThiQuynh_2020602509_proj6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
