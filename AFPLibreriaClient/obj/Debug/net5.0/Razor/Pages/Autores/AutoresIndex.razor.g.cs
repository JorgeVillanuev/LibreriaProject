#pragma checksum "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eabbae0ede457cf325d934c6a908502f8f219fa"
// <auto-generated/>
#pragma warning disable 1591
namespace AFPLibreriaClient.Pages.Autores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using AFPLibreriaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using AFPLibreriaClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using AFPLibreriaClient.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/autores")]
    public partial class AutoresIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                     autor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                           OnClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-4");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"tit\">Nombre</label>\r\n                    ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "id", "tit");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                  autor.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => autor.Nombre = __value, autor.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __Blazor.AFPLibreriaClient.Pages.Autores.AutoresIndex.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 14 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                            () => autor.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        <input type=\"submit\" class=\"btn btn-primary\" name=\"name\" value=\"Guardar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n    <hr>\r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "table-responsive");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<Autore>>(28);
            __builder.AddAttribute(29, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                 5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Autore>>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                                                  ListAutores

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ColumnWidth", "300px");
            __builder.AddAttribute(36, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                                                                                                                         Radzen.LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Autore>>(38);
                __builder2.AddAttribute(39, "Property", "Id");
                __builder2.AddAttribute(40, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Title", "ID");
                __builder2.AddAttribute(42, "Frozen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Width", "50px");
                __builder2.AddAttribute(44, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 26 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
                                                                                                                                       Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Autore>>(46);
                __builder2.AddAttribute(47, "Property", "Nombre");
                __builder2.AddAttribute(48, "Title", "Nombre");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\Autores\AutoresIndex.razor"
       
  
    public Autore autor { get; set; } = new Autore();



    List<Autore> ListAutores = new List<Autore>();
    private string api = "https://localhost:44340/api/";

    protected async override Task OnInitializedAsync()
    {
        await ObtenerAutores();
        
        
    }

    private async Task ObtenerAutores()
    {
        ListAutores = await http.GetFromJsonAsync<List<Autore>>($"{api}Autores");
    }
 
    private async Task OnClick()
    {
        
        await http.PostAsJsonAsync($"{api}Autores", autor);
        autor = new Autore();
        
        await ObtenerAutores();
        this.StateHasChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.AFPLibreriaClient.Pages.Autores.AutoresIndex
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
