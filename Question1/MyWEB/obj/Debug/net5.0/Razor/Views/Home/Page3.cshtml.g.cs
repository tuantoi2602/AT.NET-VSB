#pragma checksum "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2008e1bbdfafb7a69ab90bd35fcbe3a0769f02a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page3), @"mvc.1.0.view", @"/Views/Home/Page3.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\_ViewImports.cshtml"
using MyWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\_ViewImports.cshtml"
using MyWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2008e1bbdfafb7a69ab90bd35fcbe3a0769f02a", @"/Views/Home/Page3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f09a2ada9aab047a88e52cddfefe131c8d16eb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml"
  
    ViewData["Title"] = "Page 3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml"
 foreach (News item in (List<News>)ViewBag.News)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 198, "\"", 215, 1);
#nullable restore
#line 12 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml"
WriteAttributeValue("", 205, item.Link, 205, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link to This new</a>\r\n\r\n        </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\phamt\source\repos\Question1\MyWEB\Views\Home\Page3.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
