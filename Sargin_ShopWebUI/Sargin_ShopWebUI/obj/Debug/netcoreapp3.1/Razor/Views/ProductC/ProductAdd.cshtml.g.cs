#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf21c7d52cf7ce0927ee1ac6efdf2f79dae95c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductC_ProductAdd), @"mvc.1.0.view", @"/Views/ProductC/ProductAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf21c7d52cf7ce0927ee1ac6efdf2f79dae95c82", @"/Views/ProductC/ProductAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductC_ProductAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Pruduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
  
    ViewData["Title"] = "ProductAdd";
    Layout = "~/Views/Shared/AdvertiserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Ürün Ekleme</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
 using (Html.BeginForm("ProductAdd", "ProductC", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Ürün Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.ProductTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Ürün Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductImage, new { @class = "form-control", @placeholder = "Maksimum 400kb değerinde görsel ekleyebilirsiniz.(png/jpg/jpeg)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"form-control btn btn-gradient-info\">Resim Yükle</button>\r\n");
#nullable restore
#line 18 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Ürün Rengi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Ürün İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextAreaFor(x => x.ProductContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.ProductContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Ürün Fiyatı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductPrice, new { @class = "form-control", @type = "number" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 34 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Teklif Ver"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductOffer, new { @class = "form-control", @placeholder = "Teklif için True yazınız." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 37 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.Label("Marka"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.Marka, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-gradient-info\">Yeni Ürün Oluştur</button>\r\n");
#nullable restore
#line 41 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\ProductC\ProductAdd.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Pruduct> Html { get; private set; }
    }
}
#pragma warning restore 1591