// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Carvajal.Presentacion.Pages
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
#nullable restore
#line 5 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Administracion.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Gestion-de-vuelos")]
    public partial class Administracion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Administracion.razor"
       
    List<VueloSalidaModel> listVueloSalidaModel = null;
    RadzenDataGrid<VueloSalidaModel> grid = new();
    string[] tipoRequest = new string[2] { "post", "put" };
    protected override async Task OnInitializedAsync()
    {
        if (listVueloSalidaModel == null)
            listVueloSalidaModel = await Http.GetFromJsonAsync<List<VueloSalidaModel>>("https://localhost:44380/VueloSalida");
    }

    public async Task Eventos(int id, string action)
    {
        await DialogService.OpenAsync<Pages.VueloSalidaCrud>($"O",
               new Dictionary<string, object>() { { "Id", id } ,{ "Action", action } },
   new DialogOptions() { Width = "70%", ShowTitle = false, Resizable = true });
        listVueloSalidaModel = await Http.GetFromJsonAsync<List<VueloSalidaModel>>("https://localhost:44380/VueloSalida");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
