#pragma checksum "E:\PROYECTOS\Proyectos Programas\DeliveryApp\Delivery-App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43fc39017c597b67f56beae9fb34a421c4f6cebf"
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
#line 1 "E:\PROYECTOS\Proyectos Programas\DeliveryApp\Delivery-App\Views\_ViewImports.cshtml"
using DeliveryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROYECTOS\Proyectos Programas\DeliveryApp\Delivery-App\Views\_ViewImports.cshtml"
using DeliveryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43fc39017c597b67f56beae9fb34a421c4f6cebf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c17bd6bc47298a47a1f0d59f587625e92904df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\PROYECTOS\Proyectos Programas\DeliveryApp\Delivery-App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Delivery Fast Food";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"categorias\">\r\n\r\n");
            WriteLiteral(@"    <ul>
        <li class=""categories""><a id=""aFood"" href=""#Foods""><button>Comidas</button></a></li>

        <li class=""categories""><a href=""#Drinks"" id=""aDrink""><button>Bebidas</button></a></li>

        <li class=""categories""><a href=""#Breads"" id=""aBread""><button>Postres</button></a></li>

    </ul>

</div>


<section id=""Foods"">

    <a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 508, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Pizzas\">\r\n        <article>\r\n            <h2>Pizzas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 620, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Empanadas\">\r\n        <article>\r\n            <h2>Empanadas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 731, "\"", 738, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Pastas\">\r\n        <article>\r\n            <h2>Pastas</h2>\r\n        </article>\r\n    </a>\r\n\r\n</section>\r\n\r\n\r\n<section id=\"Drinks\">\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 891, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 892, "\"", 900, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <article>\r\n            <h2>Pizzas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 990, "\"", 997, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 998, "\"", 1006, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <article>\r\n            <h2>Empanadas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1099, "\"", 1106, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1107, "\"", 1115, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <article>\r\n            <h2>Pastas</h2>\r\n        </article>\r\n    </a>\r\n\r\n</section>\r\n\r\n<section id=\"Breads\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1242, "\"", 1249, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <article>\r\n            <h2>Pizzas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1339, "\"", 1346, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1347, "\"", 1355, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <article>\r\n            <h2>Empanadas</h2>\r\n        </article>\r\n    </a>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1448, "\"", 1455, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Pastas\">\r\n        <article>\r\n            <h2>Pastas</h2>\r\n        </article>\r\n    </a>\r\n</section>\r\n");
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
