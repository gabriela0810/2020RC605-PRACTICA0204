using System.Web;
using System.Web.Mvc;

namespace _2020RC605_PRACTICA0402
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
