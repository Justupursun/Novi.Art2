﻿using Novi.Art.Filters;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionHandler());
            filters.Add(new LogRequestFilter());
        }
    }
}
