﻿using System.Web;
using System.Web.Mvc;

namespace Niteco.EluxApiReflection
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
