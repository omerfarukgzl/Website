#pragma checksum "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "939fa5e5b9e25b19059579677677c65fb167ce34"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939fa5e5b9e25b19059579677677c65fb167ce34", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68e8701bf6065b7196e810f7e82d1baae6c9d59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<G191210068_Web_Muhasebe.Models.Cari>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container overflow: hidden;"" style=""max-width: 90%;"">
    <div class=""accordion"" id=""accordionExample"">
        <div class=""item"" id=""accordion"">
            <div class=""item-header"" id=""headingOne"">
                <h2 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                            data-target=""#collapseOne_1"" aria-expanded=""false"" aria-controls=""collapseOne"">
                        Vadeli İşlemler

                        <i class=""fa fa-angle-up"">▼</i>
                    </button>
                </h2>
            </div>
            <div id=""collapseOne_1"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                <br />
                <br />
                <div class=""row"">
                    <div class=""col-lg-12"">
                        ");
#nullable restore
#line 27 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Vadeli_Islemler"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""item"" id=""accordion"">
            <div class=""item-header"" id=""headingOne"">
                <h2 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                            data-target=""#collapseOne_2"" aria-expanded=""false"" aria-controls=""collapseOne"">
                        Borçlu Cariler

                        <i class=""fa fa-angle-up"">▼</i>
                    </button>
                </h2>
            </div>
            <div id=""collapseOne_2"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                <br />
                <br />
                <div class=""row"">
                    <div class=""col-lg-12"">

                        <div class=""panel"">
                            <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Tarihe Göre Arayınız.."" title=""Ty");
            WriteLiteral(@"pe in a name"">
                            <div class=""panel-body table-responsive"">
                                <table class=""table"" style=""min-width:800px"" id=""myTable"">
                                    <thead>
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 57 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.FirmaAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 60 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Yetkili));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 63 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 66 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 69 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th style=\"width:20%;\">\r\n                                                ");
#nullable restore
#line 72 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 75 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ToplamBorc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 78 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ToplamAlacak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 81 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Bakiye));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 87 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                         foreach (var item2 in Model)
                                        {



                                            if (item2.Bakiye < 0)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 97 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.FirmaAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 101 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Yetkili));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 104 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 107 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 110 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td style=\"width:20%;\">\r\n                                                        ");
#nullable restore
#line 114 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 117 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Borc = string.Format("{0:0,0.000}", item2.ToplamBorc);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 120 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Borc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 123 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Alacak = string.Format("{0:0,0.000}", item2.ToplamAlacak);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 126 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Alacak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 129 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Bakiyee = string.Format("{0:0,0.000}", item2.Bakiye);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 132 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Bakiyee);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 137 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"

                                            }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>
        <div class=""item"" id=""accordion"">
            <div class=""item-header"" id=""headingOne"">
                <h2 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                            data-target=""#collapseOne_3"" aria-expanded=""false"" aria-controls=""collapseOne"">
                        Alacaklı Cariler

                        <i class=""fa fa-angle-up"">▼</i>
                    </button>
                </h2>
            </div>
            <div id=""collapseOne_3"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                <br />
                <br />
                <div class=""row"">
                    <div class=""col-lg-12"">

                ");
            WriteLiteral(@"        <div class=""panel"">
                            <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Tarihe Göre Arayınız.."" title=""Type in a name"">
                            <div class=""panel-body table-responsive"">
                                <table class=""table"" style=""min-width:800px"" id=""myTable"">
                                    <thead>
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 175 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.FirmaAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 178 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Yetkili));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 181 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 184 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 187 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th style=\"width:20%;\">\r\n                                                ");
#nullable restore
#line 190 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 193 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ToplamBorc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 196 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ToplamAlacak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 199 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Bakiye));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 205 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                         foreach (var item2 in Model)
                                        {

                                            if (item2.Bakiye > 0)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 213 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.FirmaAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 217 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Yetkili));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 220 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 223 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Adres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 226 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td style=\"width:20%;\">\r\n                                                        ");
#nullable restore
#line 230 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item2.Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 233 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Borc = string.Format("{0:0,0.000}", item2.ToplamBorc);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 236 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Borc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 239 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Alacak = string.Format("{0:0,0.000}", item2.ToplamAlacak);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 242 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Alacak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n");
#nullable restore
#line 245 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                          
                                                            var donusumlu_deger_Bakiyee = string.Format("{0:0,0.000}", item2.Bakiye);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 248 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                                   Write(donusumlu_deger_Bakiyee);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 251 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>


    </div>
</div>
<br />
<br />
<br />
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel"">       
            <div class=""panel-body table-responsive"">
                <table class=""table"" style=""min-width:800px"" id=""myTable"">
                    <thead style=""background-color: #184236;"">
                        <tr>
                            <th>
                                TOPLAM ALACAK
                            </th>
                            <th>
                                TOPLAM BORÇ
                            </th>
                            <th>
                                BAKİYE
                            </th>
                        </tr>
                    </thead>
                   ");
            WriteLiteral(" <tbody style=\"background-color: #001d48;\">\r\n                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 291 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                  
                                    var donusumlu_deger_CariToplamAlacak = string.Format("{0:0,0.000}", ViewBag.ToplamAlacak);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 294 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                           Write(donusumlu_deger_CariToplamAlacak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 297 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                  
                                    var donusumlu_deger_CariToplamBorc = string.Format("{0:0,0.000}", ViewBag.ToplamBorc);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 300 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                           Write(donusumlu_deger_CariToplamBorc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 303 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                                  
                                    var donusumlu_deger_sonuc = string.Format("{0:0,0.000}", ViewBag.Bakiye);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 306 "C:\Users\Omer\Desktop\G191210068_Web_Muhasebe\G191210068_Web_Muhasebe\Views\Home\Index.cshtml"
                           Write(donusumlu_deger_sonuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<G191210068_Web_Muhasebe.Models.Cari>> Html { get; private set; }
    }
}
#pragma warning restore 1591
