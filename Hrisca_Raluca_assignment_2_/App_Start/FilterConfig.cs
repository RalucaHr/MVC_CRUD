using System.Web;
using System.Web.Mvc;

namespace Hrisca_Raluca_assignment_2_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
