#pragma checksum "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c025d421e0091dd8fb4193f76944a8f2f27a4816"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KanionStats.Components.Ejercicios.Items
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
#line 1 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemController.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemController.razor"
using BusinessLayer;

#line default
#line hidden
#nullable disable
    public partial class CreateItemController : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemController.razor"

    ItemEntity newItem = new ItemEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected async Task OnInitializeAsync()
    {
        categories = categoryService.CategoryList();
    }


    private void SaveProduct()
    {
        itemService.CreateItem(newItem);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Category categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Item itemService { get; set; }
    }
}
#pragma warning restore 1591