#pragma checksum "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7883209a647a6159b87d06c397026489f23a5a38"
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
#line 1 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7883209a647a6159b87d06c397026489f23a5a38", @"/Views/Home/Page3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
   
    ViewData["title"] = "Page3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
 foreach(News item in (List<News>)ViewBag.News)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 173, "\"", 190, 1);
#nullable restore
#line 12 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
WriteAttributeValue("", 180, item.Link, 180, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 15 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 225, "\"", 259, 1);
#nullable restore
#line 16 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page3.cshtml"
WriteAttributeValue("", 232, Url.Action("Index","Home"), 232, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a>");
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
