#pragma checksum "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97cf6c71165f65d905042f8ed0f95ebc597a0b57"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, @"<div class=""content px-4"" b-ycll5rwvk4><div class=""row text-center"" b-ycll5rwvk4><div class=""col-sm"" b-ycll5rwvk4><h2 style=""color:blue"" class=""tilt-page-form"" b-ycll5rwvk4>
                CONSULTAR SALIDA VUELOS <span title=""Ver detalle"" class=""oi oi-location"" aria-hidden=""true"" b-ycll5rwvk4></span></h2></div></div></div>");
#nullable restore
#line 20 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
 if (listVueloSalidaModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p b-ycll5rwvk4><em b-ycll5rwvk4>Cargando...</em></p>");
#nullable restore
#line 23 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenPanel>(6);
            __builder.AddAttribute(7, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "complement-filter-form");
            __builder.AddAttribute(9, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<div class=\"ml-2\" b-ycll5rwvk4>Resultado</div>");
            }
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<VueloSalidaModel>>(12);
                __builder2.AddAttribute(13, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                                    FilterMode.Simple

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                                                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "class", "grid-contain-form");
                __builder2.AddAttribute(18, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ColumnWidth", "200px");
                __builder2.AddAttribute(21, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<VueloSalidaModel>>(
#nullable restore
#line 32 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                              listVueloSalidaModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 32 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                                                                                                    LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(24);
                    __builder3.AddAttribute(25, "Property", "Origen");
                    __builder3.AddAttribute(26, "Title", "Origen");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(28);
                    __builder3.AddAttribute(29, "Property", "Destino");
                    __builder3.AddAttribute(30, "Title", "Destino");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(32);
                    __builder3.AddAttribute(33, "Property", "Municipio");
                    __builder3.AddAttribute(34, "Title", "Municipio");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(36);
                    __builder3.AddAttribute(37, "Property", "Fecha");
                    __builder3.AddAttribute(38, "Title", "Fecha");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(40);
                    __builder3.AddAttribute(41, "Property", "Salida");
                    __builder3.AddAttribute(42, "Title", "Salida");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(44);
                    __builder3.AddAttribute(45, "Property", "IdEstado");
                    __builder3.AddAttribute(46, "Title", "Estado");
                    __builder3.AddAttribute(47, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VueloSalidaModel>)((vueloSalida) => (__builder4) => {
#nullable restore
#line 41 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                             if (vueloSalida.IdEstado == 1)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(48, "<p style=\"color:green\" b-ycll5rwvk4>Activo <span title=\"Activo\" class=\"oi oi-thumb-up\" aria-hidden=\"true\" b-ycll5rwvk4></span></p>");
#nullable restore
#line 44 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(49, "<p style=\"color:red\" b-ycll5rwvk4>Cancelado <span title=\"Cancelado\" class=\"oi oi-thumb-down\" aria-hidden=\"true\" b-ycll5rwvk4></span></p>");
#nullable restore
#line 48 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VueloSalidaModel>>(51);
                    __builder3.AddAttribute(52, "Width", "150px");
                    __builder3.AddAttribute(53, "Property", "VueloSalida");
                    __builder3.AddAttribute(54, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Title", "Acciones");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VueloSalidaModel>)((vueloSalida) => (__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(58);
                        __builder4.AddAttribute(59, "class", "nav-link grid-accciones d-flex");
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(61, "button");
                            __builder5.AddAttribute(62, "class", "btn-plus-search btn-sm");
                            __builder5.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                                                                 (()=>VueloSalidaDetalle(vueloSalida.IdSalida))

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "b-ycll5rwvk4");
                            __builder5.AddMarkupContent(65, "<span title=\"Ver detalle\" class=\"oi oi-eye\" aria-hidden=\"true\" b-ycll5rwvk4></span>");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(66, (__value) => {
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
                                   grid = (Radzen.Blazor.RadzenDataGrid<VueloSalidaModel>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 65 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\Index.razor"
       
    List<VueloSalidaModel> listVueloSalidaModel = null;
    RadzenDataGrid<VueloSalidaModel> grid = new();

    protected override async Task OnInitializedAsync()
    {
        if (listVueloSalidaModel == null)
            listVueloSalidaModel = await Http.GetFromJsonAsync<List<VueloSalidaModel>>("https://localhost:44380/VueloSalida");
    }

    async Task VueloSalidaDetalle(int id)
    {
        await DialogService.OpenAsync<Pages.VueloSalidaDetalle>($"O",
               new Dictionary<string, object>() { { "Id", id } },
   new DialogOptions() { Width = "70%", ShowTitle = false, Resizable = true });
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
