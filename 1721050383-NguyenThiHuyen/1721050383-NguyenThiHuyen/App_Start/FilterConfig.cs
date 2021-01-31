using System.Web;
using System.Web.Mvc;

namespace _1721050383_NguyenThiHuyen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
