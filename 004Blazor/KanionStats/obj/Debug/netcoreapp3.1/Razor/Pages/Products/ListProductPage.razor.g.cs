#pragma checksum "C:\projects\Learning\004Blazor\KanionStats\Pages\Products\ListProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61618eb6ade0daaf141d3e49018a185d393d2ca8"
// <auto-generated/>
#pragma warning disable 1591
namespace KanionStats.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Components.Ejercicios.Items;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Components.Ejercicios.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Components.Ejercicios.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Pages.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Pages.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\projects\Learning\004Blazor\KanionStats\_Imports.razor"
using KanionStats.Pages.InOuts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items/list")]
    public partial class ListProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of Items</h3>\r\n");
            __builder.OpenComponent<KanionStats.Components.Ejercicios.Items.ListItemsComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n<hr>\r\n    ");
            __builder.AddMarkupContent(3, "<a href=\"products/create\">Crear Producto</a>\r\n<hr>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
