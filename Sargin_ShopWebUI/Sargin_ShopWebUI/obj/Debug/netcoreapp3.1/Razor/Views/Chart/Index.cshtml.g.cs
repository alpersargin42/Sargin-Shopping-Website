#pragma checksum "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786908237cd9953cca158ffbca601165b2d2ec14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_Index), @"mvc.1.0.view", @"/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786908237cd9953cca158ffbca601165b2d2ec14", @"/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334ae3fe344fff619536abea410693be29302f20", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alper\Documents\GitHub\primefor-2022-staj-alpersargin42\Sargin_ShopWebUI\Sargin_ShopWebUI\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div id=""chartdiv"" style=""width: 800px; height: 600px"">
        <h2>Buras?? chart alan??d??r.</h2>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(Drawonload);
    function Drawonload() {
        $(function() {
            $.ajax({
                type: 'GET',
                url: '/Chart/CategoryChart/',
                success:function(chartsdata) {
                    var Data = chartsdata.jsonlist;
                    var data = new google.visualization.DataTable();

                    data.addColumn('string', 'categoryname');
                    data.addColumn('number', 'categorycount');

                    for (var i = 0; i < Data.length; i++) {
                        data.addRow([Data[i].categoryname,Data[i].categorycount]);
                    }
                  ");
            WriteLiteral(@"  var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                    chart.draw(data,
                        {
                            title: 'Google Chart',
                            position: ""top"",
                            fontsize: ""16px""
                        });
                }
            })
        })
    }
</script>

");
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
