#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4623a8dfb828d9ff7bffe47e67711bda8efcbdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4623a8dfb828d9ff7bffe47e67711bda8efcbdb", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Advertiser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Kay??t Ol</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 12 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Ad??n??z Soyad??n??z</label>\r\n                            ");
#nullable restore
#line 17 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.AdvertiserName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 18 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.AdvertiserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Mail Adresiniz</label>\r\n                            ");
#nullable restore
#line 23 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.AdvertiserMail,new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.AdvertiserMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">
                                ??ifreniz
                            </label>
                            ");
#nullable restore
#line 33 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.AdvertiserPassword, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.AdvertiserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword2 mb-2"">
                                ??ifre Tekrar
                            </label>
                            ");
#nullable restore
#line 41 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.AdvertiserPassword1, new { @class = "form-control",@type="password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.AdvertiserPassword1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kay??t Ol</button>\r\n");
#nullable restore
#line 47 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Advertiser> Html { get; private set; }
    }
}
#pragma warning restore 1591
