#pragma checksum "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d2a29fd08b005f79b2131eb285b46256d7ee594"
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
#line 2 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Detalle/VueloSalidaCrud/{id:int}/{action}")]
    public partial class VueloSalidaCrud : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
 if (vueloSalidaModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"d-flex justify-content-center\"><div class=\"spinner-border\" role=\"status\"><span class=\"sr-only\">-cargando...</span></div></div>");
#nullable restore
#line 19 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row text-center");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm");
            __builder.OpenElement(10, "h2");
            __builder.AddAttribute(11, "style", "color:blue");
            __builder.AddAttribute(12, "class", "title-page-form");
            __builder.AddMarkupContent(13, "Acción ");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                       Action

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, " <span title=\"Ver detalle\" class=\"oi oi-location\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "style", "color:red");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                              messageError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "style", "color:green");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                sucess

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(27);
            __builder.AddAttribute(28, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "form-radzen-search");
            __builder.AddAttribute(30, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "<strong class=\"tittle-card\">Detalle salida de vuelo</strong>");
            }
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "container");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "card");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(39);
                __builder2.AddAttribute(40, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 42 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                          vueloSalidaModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-6");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "form-group");
                    __builder3.AddMarkupContent(48, "<label>Origen <span title=\"Origen\" class=\"oi oi-location\" aria-hidden=\"true\"></span></label>\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                    __builder3.AddAttribute(50, "class", "form-control");
                    __builder3.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                 vueloSalidaModel.Origen

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vueloSalidaModel.Origen = __value, vueloSalidaModel.Origen))));
                    __builder3.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vueloSalidaModel.Origen));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                                ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-6");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "form-group");
                    __builder3.AddMarkupContent(59, "<label>Destino <span title=\"Destino\" class=\"oi oi-location\" aria-hidden=\"true\"></span></label>\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                    __builder3.AddAttribute(61, "class", "form-control");
                    __builder3.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                 vueloSalidaModel.Destino

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vueloSalidaModel.Destino = __value, vueloSalidaModel.Destino))));
                    __builder3.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vueloSalidaModel.Destino));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n                                ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "col-md-6");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "form-group");
                    __builder3.AddMarkupContent(70, "<label>Fecha <span title=\"Fecha\" class=\"oi oi-timer\" aria-hidden=\"true\"></span></label>\r\n                                        ");
                    __Blazor.Carvajal.Presentacion.Pages.VueloSalidaCrud.TypeInference.CreateInputDate_0(__builder3, 71, 72, "form-control", 73, 
#nullable restore
#line 60 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                 vueloSalidaModel.Fecha

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vueloSalidaModel.Fecha = __value, vueloSalidaModel.Fecha)), 75, () => vueloSalidaModel.Fecha);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n                                ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-6");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "form-group");
                    __builder3.AddMarkupContent(81, "<label>Hora de salida <span title=\"Salida\" class=\"oi oi-timer\" aria-hidden=\"true\"></span></label>\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(82);
                    __builder3.AddAttribute(83, "class", "form-control");
                    __builder3.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                 vueloSalidaModel.Salida

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vueloSalidaModel.Salida = __value, vueloSalidaModel.Salida))));
                    __builder3.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vueloSalidaModel.Salida));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                                        <span title=\"Ver detalle\" class=\"oi oi-timer\" aria-hidden=\"true\"></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n                                ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-6");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "form-group");
                    __builder3.AddMarkupContent(93, "<label>Estado <span title=\"Salida\" class=\"oi oi-rain\" aria-hidden=\"true\"></span></label>");
#nullable restore
#line 73 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                         if (vueloSalidaModel.IdEstado == 1)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(94, "<p style=\"color:green\">Activo <span title=\"Activo\" class=\"oi oi-thumb-up\" aria-hidden=\"true\"></span></p>");
#nullable restore
#line 76 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(95, "<p style=\"color:red\">Cancelado <span title=\"Cancelado\" class=\"oi oi-thumb-down\" aria-hidden=\"true\"></span></p>");
#nullable restore
#line 80 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                        }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\r\n\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(97);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(99);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n    <br>\r\n    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "form-group");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "row");
            __builder.OpenElement(105, "center");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "type", "submit");
            __builder.AddAttribute(108, "class", "btn btn-primary button-complement-xl");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                                               () => EventoTabla()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(110, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\"></span> GUARDAR\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.OpenElement(112, "center");
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "type", "submit");
            __builder.AddAttribute(115, "class", "btn btn-outline-primary button-complement-xl");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
                                                                                                     (()=> dialogService.Close(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(117, "<span class=\"oi oi-arrow-left\" aria-hidden=\"true\"></span> REGRESAR\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 109 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Proyectos\Pruebas técnicas\Carvajal\CarvajalFront\Carvajal.Front\Carvajal.Presentacion\Pages\VueloSalidaCrud.razor"
       
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public string Action { get; set; }

    string messageError = String.Empty;

    string sucess = String.Empty;


    VueloSalidaModel vueloSalidaModel = null;

    RadzenDataGrid<VueloSalidaModel> grid = new();

    protected override async Task OnInitializedAsync()
    {
        var url = $"https://localhost:44380/VueloSalida/ObtenerPorId/" + $"{Id}";
        if (vueloSalidaModel == null)
            vueloSalidaModel = await _http.GetFromJsonAsync<VueloSalidaModel>(url);

    }

    public async Task EventoTabla()
    {
        var json = JsonConvert.SerializeObject(vueloSalidaModel);
        var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

        switch (Action.ToLower())
        {
            case "post":
                var httpResponsePost = await _http.PostAsync($"https://localhost:44380/VueloSalida/", stringContent);
                if (httpResponsePost.IsSuccessStatusCode)
                {
                    var url = $"https://localhost:44380/VueloSalida/ObtenerPorId/" + $"{Id}";
                    vueloSalidaModel = await _http.GetFromJsonAsync<VueloSalidaModel>(url);
                    sucess = "Datos insertados correctamente";
                    dialogService.Close(false);
                }
                else
                    messageError = "Los Datos no se pudieron guardar";
                break;
            case "put":
                var httpResponsePust = await _http.PutAsync($"https://localhost:44380/VueloSalida/", stringContent);
                if (httpResponsePust.IsSuccessStatusCode)
                {
                    var url = $"https://localhost:44380/VueloSalida/ObtenerPorId/" + $"{Id}";
                    vueloSalidaModel = await _http.GetFromJsonAsync<VueloSalidaModel>(url);
                    sucess = "Datos insertados correctamente";
                    dialogService.Close(false);
                }
                else
                    messageError = "Los Datos no se pudieron guardar";
                break;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.Carvajal.Presentacion.Pages.VueloSalidaCrud
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
