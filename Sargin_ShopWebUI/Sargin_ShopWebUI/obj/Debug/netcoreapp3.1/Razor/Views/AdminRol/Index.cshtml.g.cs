#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fdb681e57368d32c4d7166b7d3eb226545a56e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRol_Index), @"mvc.1.0.view", @"/Views/AdminRol/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7fdb681e57368d32c4d7166b7d3eb226545a56e", @"/Views/AdminRol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.AppRole>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7fdb681e57368d32c4d7166b7d3eb226545a56e3569", async() => {
                WriteLiteral("\r\n<h1>Roller</h1>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>Sil</th>\r\n        \r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td><a href=\"/AdminRol/RoleDelete\" class=\"btn btn-danger\">Sil</a></td>\r\n            \r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\AdminRol\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/AdminRol/AddRole\" class=\"btn btn-primary\">Yeni Rol Ekle</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.AppRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591