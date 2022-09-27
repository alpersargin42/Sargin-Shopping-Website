using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Excel;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ExportStaticExcelProductList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ürün Listesi");
                worksheet.Cell(1, 1).Value = "Ürün ID";
                worksheet.Cell(1, 2).Value = "Ürün Adı";

                int ProductRowCount = 2;
                foreach (var item in GetProductLİST())
                {
                    worksheet.Cell(ProductRowCount, 1).Value = item.ID;
                    worksheet.Cell(ProductRowCount, 2).Value = item.ProductNAME;
                    ProductRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Calisma1.xlsx");
                }
            }
            //return View();
        }

        List<ProductModel> GetProductLİST()
        {
            List<ProductModel> pm = new List<ProductModel>()
            {
                new ProductModel { ID = 15, ProductNAME = "Bilgisayar" },
                new ProductModel { ID = 16, ProductNAME = "Beyaz Eşya" },
                new ProductModel { ID = 17, ProductNAME = "Telefon" }

            };
            return pm;
        }

        public IActionResult ProductListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelProductList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ürün Listesi");
                worksheet.Cell(1, 1).Value = "Ürün ID";
                worksheet.Cell(1, 2).Value = "Ürün Adı";

                int ProductRowCount = 2;
                foreach (var item in ProductTitleList())
                {
                    worksheet.Cell(ProductRowCount, 1).Value = item.ID;
                    worksheet.Cell(ProductRowCount, 2).Value = item.ProductNAME;
                    ProductRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }

        public List<ProductModel2> ProductTitleList()
        {
            List<ProductModel2> pm = new List<ProductModel2>();
            using (var c = new Context())
            {
                pm = c.Pruducts.Select(x => new ProductModel2
                {
                    ID = x.ProductID,
                    ProductNAME = x.ProductTitle
                }).ToList();
                return pm;

            }
        }

        public IActionResult ProductTitleListExcel()
        {
            return View();
        }
    }
}
