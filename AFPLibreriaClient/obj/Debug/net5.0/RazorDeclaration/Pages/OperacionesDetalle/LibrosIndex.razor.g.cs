// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AFPLibreriaClient.Pages.OperacionesDetalle
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/libros")]
    public partial class LibrosIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\Jorge Villanueva\Desktop\AfpPrueba\LibreriaProject\AFPLibreriaClient\Pages\OperacionesDetalle\LibrosIndex.razor"
       
    public string imageUrl;

    public Libro libro { get; set; } = new Libro();

    public List<Categoria> ListCategorias { get; set; } = new List<Categoria>();
    public List<Autore> ListAutores { get; set; } = new List<Autore>();

    List<Libro> ListLibros = new List<Libro>();
    private string api = "https://localhost:44340/api/";

    protected async override Task OnInitializedAsync()
    {
        await ObtenerLibros();
        await ObtenrAutores();
        await ObtenrCategorias();
    }

    private async Task ObtenerLibros()
    {
        ListLibros = await http.GetFromJsonAsync<List<Libro>>($"{api}Libros");
    }
    private async Task<List<Categoria>> ObtenrCategorias()
    {
        ListCategorias = await http.GetFromJsonAsync<List<Categoria>>($"{api}categorias");

        return ListCategorias;
    }
    private async Task<List<Autore>> ObtenrAutores()
    {
        ListAutores = await http.GetFromJsonAsync<List<Autore>>($"{api}autores");

        return ListAutores;
    }

    private async Task LoadData(LoadDataArgs args, string opcion)
    {
        switch (opcion)
        {
            case "cat":
                var query = await ObtenrCategorias();

                if (!string.IsNullOrEmpty(args.Filter))
                {
                    query = query.Where(c => c.Categoria1.ToLower().Contains(args.Filter.ToLower())).ToList();
                }
                ListCategorias = query;
                break;
            case "aut":
                var query1 = await ObtenrAutores();

                if (!string.IsNullOrEmpty(args.Filter))
                {
                    query1 = query1.Where(c => c.Nombre.ToLower().Contains(args.Filter.ToLower())).ToList();
                }
                ListAutores = query1;
                break;
        }
        await InvokeAsync(StateHasChanged);
    }

    private string format = "image/png";
    private IBrowserFile imagen;
    private async Task OnChange(InputFileChangeEventArgs e)
    {
        imagen = e.GetMultipleFiles().FirstOrDefault();
        var buffer = new byte[imagen.Size];
        await imagen.OpenReadStream().ReadAsync(buffer);
        imageUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
        this.StateHasChanged();
    }

    private async Task OnClick()
    {
        libro.Imagen = imageUrl;
        await http.PostAsJsonAsync($"{api}Libros", libro);
        libro = new Libro();
        imageUrl = null;
        await ObtenerLibros();
        this.StateHasChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
