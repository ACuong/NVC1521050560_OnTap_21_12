﻿using System.Web;
using System.Web.Mvc;

namespace NVC1521050560
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
