#pragma checksum "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Storage\CreateStorageComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2beb9906b2c0b3ff5b9b643c89c0a93d0db0f919"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KanionStats.Components.Ejercicios.Storage
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
#nullable restore
#line 1 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Storage\CreateStorageComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Storage\CreateStorageComponent.razor"
using BusinessLayer;

#line default
#line hidden
#nullable disable
    public partial class CreateStorageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Storage\CreateStorageComponent.razor"


    string message = "";

    StorageEntity objStorage = new StorageEntity();
    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<ItemEntity> items = new List<ItemEntity>();

    protected override async Task OnInitializedAsync()
    {
        warehouses = warehouseService.WarehouseList();
        items = itemsService.ItemList();
    }

    private void SaveStorage()
    {
        if (!storageService.IsProductInWarehouse(objStorage.ItemId, objStorage.WarehouseId))
        {
            objStorage.StorageId = $"{objStorage.WarehouseId}-{objStorage.ItemId}";
            objStorage.LastUpdate = DateTime.Now;
            storageService.CreateStorage(objStorage);
            message = $"Successful creation of Storage for item {objStorage.ItemId} in warehouse {objStorage.WarehouseId}";
        }
        else
        {
            message = $"There is a product {objStorage.ItemId} stored in warehouse {objStorage.WarehouseId}";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Storage storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Item itemsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Warehouse warehouseService { get; set; }
    }
}
#pragma warning restore 1591
