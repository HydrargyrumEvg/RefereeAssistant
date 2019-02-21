using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// Лететь
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static MvcHtmlString Fly(this HtmlHelper html)
        {
            return MvcHtmlString.Create("<input type=\"button\" value=\"Fly\" class=\"btn btn-primary\" />");
        }
    }
}