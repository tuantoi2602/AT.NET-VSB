#pragma checksum "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54adef18a82801c5cbbbc53b8724e9e63cc8c4f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page2), @"mvc.1.0.view", @"/Views/Home/Page2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54adef18a82801c5cbbbc53b8724e9e63cc8c4f6", @"/Views/Home/Page2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
   
    ViewData["title"] = "Page2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
 foreach(var item in (List<ContactForm>)ViewBag.Contact)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 8 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
   Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 9 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
   Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 10 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
   Write(item.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 11 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
   Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr> <br/>\r\n");
#nullable restore
#line 13 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 232, "\"", 266, 1);
#nullable restore
#line 14 "C:\Users\tuanh\Desktop\FinalTestAT\FinalAT\FinalAT\Web\Views\Home\Page2.cshtml"
WriteAttributeValue("", 239, Url.Action("Index","Home"), 239, 27, false);

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