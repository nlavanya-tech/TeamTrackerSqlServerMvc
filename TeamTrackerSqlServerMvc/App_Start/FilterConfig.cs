using System.Web;
using System.Web.Mvc;

namespace TeamTrackerSqlServerMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
