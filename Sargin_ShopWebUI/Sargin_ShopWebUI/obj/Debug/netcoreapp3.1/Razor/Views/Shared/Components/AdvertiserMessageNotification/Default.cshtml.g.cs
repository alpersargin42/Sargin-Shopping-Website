#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63fd3bb78cdf7b6273e85e97aaed6b5e8ea4465c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdvertiserMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdvertiserMessageNotification/Default.cshtml")]
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
#line 1 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63fd3bb78cdf7b6273e85e97aaed6b5e8ea4465c", @"/Views/Shared/Components/AdvertiserMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdvertiserMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Teklifler</h6>\r\n    <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 7 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 403, "\"", 441, 1);
#nullable restore
#line 11 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
WriteAttributeValue("", 409, item.SenderUser.AdvertiserImage, 409, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 14 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
                                                                        Write(item.SenderUser.AdvertiserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana teklif gönderdi.</h6>\r\n                <p>");
#nullable restore
#line 15 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
              Write(item.MessageDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"text-gray mb-0\"> ");
#nullable restore
#line 16 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
                                      Write(item.MessageDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 19 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Shared\Components\AdvertiserMessageNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 class=\"p-3 mb-0 text-center\">Yeni Teklif</h6>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
