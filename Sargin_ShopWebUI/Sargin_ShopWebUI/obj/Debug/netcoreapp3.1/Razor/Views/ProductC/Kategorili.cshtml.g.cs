#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5221e0dbde9e9459059e3b6e3bc41c7e652c0e40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductC_Kategorili), @"mvc.1.0.view", @"/Views/ProductC/Kategorili.cshtml")]
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
#line 1 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\_ViewImports.cshtml"
using Sargin_ShopWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\_ViewImports.cshtml"
using Sargin_ShopWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221e0dbde9e9459059e3b6e3bc41c7e652c0e40", @"/Views/ProductC/Kategorili.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductC_Kategorili : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pruduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
  
    ViewData["Title"] = "Kategorili";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">SEÇTİĞİNİZ KATEGORİDEKİ ÜRÜNLER</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 18 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 722, "\"", 746, 1);
#nullable restore
#line 22 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
WriteAttributeValue("", 728, item.ProductImage, 728, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 778, "\"", 784, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-list-alt""></i> ");
#nullable restore
#line 28 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                                      Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 29 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                                 Write(item.ProductThumbnailImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 30 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                                 Write(item.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1544, "\"", 1592, 3);
            WriteAttributeValue("", 1551, "/ProductC/ProductReadAll/", 1551, 25, true);
#nullable restore
#line 36 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
WriteAttributeValue("", 1576, item.ProductID, 1576, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1591, "/", 1591, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                                                   Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 38 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                     Write(item.ProductContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1775, "\"", 1823, 3);
            WriteAttributeValue("", 1782, "/ProductC/ProductReadAll/", 1782, 25, true);
#nullable restore
#line 39 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
WriteAttributeValue("", 1807, item.ProductID, 1807, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1822, "/", 1822, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">");
#nullable restore
#line 39 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                                                                                                              Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-lira-sign\"></i>></a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\Kategorili.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pruduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
