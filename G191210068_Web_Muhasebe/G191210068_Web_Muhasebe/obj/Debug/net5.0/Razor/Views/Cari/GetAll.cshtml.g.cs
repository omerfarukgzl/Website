#pragma checksum "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3eaec9ec2546d128763d92a8077b0980ad0fa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cari_GetAll), @"mvc.1.0.view", @"/Views/Cari/GetAll.cshtml")]
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
#line 1 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\_ViewImports.cshtml"
using G191210068_Web_Muhasebe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\_ViewImports.cshtml"
using G191210068_Web_Muhasebe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3eaec9ec2546d128763d92a8077b0980ad0fa9a", @"/Views/Cari/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68e8701bf6065b7196e810f7e82d1baae6c9d59", @"/Views/_ViewImports.cshtml")]
    public class Views_Cari_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<G191210068_Web_Muhasebe.Models.PdfClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    thead, tfoot {
        display: table-row-group
    }
    tr, th {
        text-align: center
    }
</style>

<table class=""table"" width=""100%"" style=""border-bottom: 1px solid #ddd;"">
    <thead style=""background-color: #0D8A6E; color: white"">
        <tr>
            <th>
                FİRMA
            </th>
            <th>
                YETKİLİ
            </th>
            <th>
                GRUP
            </th>
        </tr>
    </thead>
    <tbody style=""background-color: #C4D0CD"">
        <tr>
            <td>
                ");
#nullable restore
#line 33 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(ViewBag.CariAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(ViewBag.Yetkili);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(ViewBag.Grup);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
    </tbody>
</table>
<br />
<br />

<table class=""table"" width=""100%""  style=""border-bottom: 1px solid #ddd;"">
    <thead style=""background-color: #2B606A; color: white"">
        <tr>
            <th>
                ");
#nullable restore
#line 51 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.FaturaTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.VadeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.odemeSekli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.Borc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.Alacak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.CariIslemler.islemTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Bakiye\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody style=\"background-color: #C4D0CD \">\r\n\r\n");
#nullable restore
#line 81 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
          
            int cariIslemId = -1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
         foreach (var item in Model)
        {
            var bakiye = item.CariIslemler.Borc - item.CariIslemler.Alacak;
            if (cariIslemId != item.CariIslemler.CariIslemlerID)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 91 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CariIslemler.FaturaTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 94 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CariIslemler.VadeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 100 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CariIslemler.odemeSekli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CariIslemler.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 106 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                          
                            var donusumlu_deger_Borc = string.Format("{0:0,0.000}", item.CariIslemler.Borc);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 109 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(donusumlu_deger_Borc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 113 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                          
                            var donusumlu_deger_Alacak = string.Format("{0:0,0.000}", item.CariIslemler.Alacak);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 116 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(donusumlu_deger_Alacak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 120 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CariIslemler.islemTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 123 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                          
                            var donusumlu_deger_bakiye = string.Format("{0:0,0.000}", bakiye);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 126 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                   Write(donusumlu_deger_bakiye);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 130 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"

                cariIslemId = item.CariIslemler.CariIslemlerID;

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                 foreach (var item2 in Model.Where(x => x.CariIslemler.CariIslemlerID == item.CariIslemler.CariIslemlerID).ToList())
                {
                    if (item2.CariIslemler.islemTuru == IslemTuru.Alis || item2.CariIslemler.islemTuru == IslemTuru.Satis)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr style=""background-color: #E4EDEA"">
                            <td>
                                |_____
                            </td>
                            <td>

                            </td>
                            <td>
                                Ürün Adı:
                            </td>
                            <td>
                                ");
#nullable restore
#line 148 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                           Write(Html.DisplayFor(modelItem => item2.Urun.UrunAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                Miktar: ");
#nullable restore
#line 151 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                   Write(Html.DisplayFor(modelItem => item2.Urun.Miktar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 154 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                  
                                    var donusumlu_deger_BirimFiyat = string.Format("{0:0,0.000}", item.Urun.BirimFiyat);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                Birim F:  ");
#nullable restore
#line 157 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                     Write(donusumlu_deger_BirimFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                               Tutar\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 163 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                  
                                    var donusumlu_deger_Toplam = string.Format("{0:0,0.000}", item.Urun.Toplam);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 166 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                           Write(donusumlu_deger_Toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 170 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr style=""background-color: #E4EDEA"">
                            <td>
                                +|_____
                            </td>
                            <td>

                            </td>
                            <td>
                                İşlem Türü:
                            </td>
                            <td>
                                ");
#nullable restore
#line 185 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                           Write(Html.DisplayFor(modelItem => item2.CariIslemler.islemTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 188 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                  
                                    var donusumlu_deger_Odenen = string.Format("{0:0,0.000}", item.CariIslemler.Odenen);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                Miktar: ");
#nullable restore
#line 191 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                   Write(donusumlu_deger_Odenen);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                            </td>\r\n                            <td></td>\r\n                            <td>\r\n                                Tutar:\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 198 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                                  
                                    var donusumlu_deger_Odenen2 = string.Format("{0:0,0.000}", item.CariIslemler.Odenen);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                               ");
#nullable restore
#line 201 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                          Write(donusumlu_deger_Odenen2);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 204 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                 
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 217 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
  
    var sonuc = ViewBag.CariToplamBorc - ViewBag.CariToplamAlacak;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"" width=""100%"" style=""border-bottom: 1px solid #ddd;"">
    <thead style=""background-color: #0D8A6E; color: white"">
        <tr>
            <th>
                ALACAK
            </th>
            <th>
                BORÇ
            </th>
            <th>
                BAKİYE
            </th>
            <th>
                DURUM
            </th>

        </tr>
    </thead>
    <tbody style=""background-color: #C4D0CD"">
        <tr>
            <td>
");
#nullable restore
#line 241 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                  
                    var donusumlu_deger_CariToplamAlacak = string.Format("{0:0,0.000}", ViewBag.CariToplamAlacak);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 244 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(donusumlu_deger_CariToplamAlacak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 248 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                  
                    var donusumlu_deger_CariToplamBorc = string.Format("{0:0,0.000}", ViewBag.CariToplamBorc);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 251 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(donusumlu_deger_CariToplamBorc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 255 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
                  
                    var donusumlu_deger_sonuc = string.Format("{0:0,0.000}", sonuc);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 258 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
           Write(donusumlu_deger_sonuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n\r\n");
#nullable restore
#line 262 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
             if (sonuc < 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Cari Alacaklı\r\n                </td>\r\n");
#nullable restore
#line 267 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 268 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
             if (sonuc > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Cari Borçlu\r\n                </td>\r\n");
#nullable restore
#line 273 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 274 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
             if (sonuc == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Borç Alacak Eşit\r\n                </td>\r\n");
#nullable restore
#line 279 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Cari\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LanguageService language { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<G191210068_Web_Muhasebe.Models.PdfClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
