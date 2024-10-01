using System.Web;
using System.Web.Mvc;

namespace vn.com.BTap4_21520739
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
