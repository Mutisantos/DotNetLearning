#pragma checksum "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f15f69200a1367306cd36717d513d01e95855f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "C:\projects\Learning\002aspnet\Views\_ViewImports.cshtml"
using _002aspnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Learning\002aspnet\Views\_ViewImports.cshtml"
using _002aspnet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f15f69200a1367306cd36717d513d01e95855f2", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1a85b8e81e20b3e4ac04665c1f21de20c4a797", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Escuela Lekh Vezé";
    Layout = "_BaseTemplate";
    var numberValue = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bienvenido a la escuela ");
#nullable restore
#line 10 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
                                             Write(numberValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>Nombre: ");
#nullable restore
#line 11 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p><strong>Fundación: ");
#nullable restore
#line 12 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
                     Write(Model.AñoFundación);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></p>\r\n    <p><i>");
#nullable restore
#line 13 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
     Write(ViewBag.miCosaCustom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n    <p><i>");
#nullable restore
#line 14 "C:\projects\Learning\002aspnet\Views\Escuela\Index.cshtml"
     Write(ViewData["miCosaCustom"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
