#pragma checksum "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a68b1a5d4ebfe90483ebf73c7520a5a44aa1506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using YAB.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using YAB.AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using YAB.AdvertisementApp.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a68b1a5d4ebfe90483ebf73c7520a5a44aa1506", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff9b82cad0abf3def69d4fd14a5b9937987b7a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header class=""masthead text-center text-white"">
    <div class=""masthead-content"">
        <div class=""container px-5"">
            <h1 class=""masthead-heading mb-0"">YAB Bilişim</h1>
            <h2 class=""masthead-subheading mb-0"">Masaüstü, Web ve Mobil Uygulamalar</h2>
            <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Daha Fazla</a>
        </div>
    </div>
    <div class=""bg-circle-1 bg-circle""></div>
    <div class=""bg-circle-2 bg-circle""></div>
    <div class=""bg-circle-3 bg-circle""></div>
    <div class=""bg-circle-4 bg-circle""></div>
</header>

");
#nullable restore
#line 20 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
 for (int i = 0; i < Model?.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"scroll\">\r\n        <div class=\"container px-5\">\r\n            <div class=\"row gx-5 align-items-center\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 874, "\"", 917, 2);
            WriteAttributeValue("", 882, "col-lg-6", 882, 8, true);
#nullable restore
#line 25 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 890, i%2==0?" order-lg-2":"", 891, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\"><img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 995, "\"", 1020, 1);
#nullable restore
#line 26 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1001, Model[i].ImagePath, 1001, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1076, "\"", 1119, 2);
            WriteAttributeValue("", 1084, "col-lg-6", 1084, 8, true);
#nullable restore
#line 28 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1092, i%2==0?" order-lg-1":"", 1093, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\">\r\n                        <h2 class=\"display-4\">");
#nullable restore
#line 30 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
                                         Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 31 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 37 "C:\Users\yusuf\source\repos\YAB.AdvertisementApp\YAB.AdvertisementApp.UI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
