#pragma checksum "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46f76dad7732ea0d98a2b0220d2712e988074c42"
// <auto-generated/>
#pragma warning disable 1591
namespace Carvajal.Presentacion.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Carvajal.Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Carvajal.Presentacion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Carvajal.Presentacion.Data.VueloSalidaModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-l9itannnmf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-l9itannnmf");
            __builder.OpenComponent<Carvajal.Presentacion.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-l9itannnmf");
            __builder.AddMarkupContent(11, @"<div class=""d-flex flex-row"" b-l9itannnmf><a class=""nav-link p-2"" href style=""color:blue"" b-l9itannnmf><span class=""oi oi-location"" aria-hidden=""true"" b-l9itannnmf></span> Vuelos salientes
            </a>
            <a class=""nav-link p-2"" href=""/Gestion-de-vuelos"" style=""color:blue"" b-l9itannnmf><span class=""oi oi-location"" aria-hidden=""true"" b-l9itannnmf></span> Administración
            </a></div>

        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-l9itannnmf");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
