using System.Web;
using System.Web.Mvc;

namespace PRELIM_E3_LastNameFirstName_Section
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
