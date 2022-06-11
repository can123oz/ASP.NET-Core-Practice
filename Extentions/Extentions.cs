using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zeroToHeroMVC.Extentions
{
    static public class Extentions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeHolder)
        {
            return htmlHelper.TextBox(name, value, new 
            { 
                style="background-color:green;color:white;font-site:11px",
                @class = "form-input",
                a = "a",
                b = "b",
                placeHolder = placeHolder
            });
        }
    }
}
