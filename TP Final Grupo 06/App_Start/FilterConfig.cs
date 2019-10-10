using System.Web;
using System.Web.Mvc;

namespace TP_Final_Grupo_06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
