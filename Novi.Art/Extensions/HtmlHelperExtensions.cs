﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Copyright(this HtmlHelper helper)
        {
            return helper.Raw($"&copy; Novi.Art {DateTime.Now.Year}");
        }
    }
}