#pragma checksum "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccdff4fd22d62432ca075a9075749bd6afb4ae2e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
using BusinessLayer;

#line default
#line hidden
#nullable disable
    public partial class CreateItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                 newItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<label>\r\n            Item Reference:\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                newItem.ItemId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItem.ItemId = __value, newItem.ItemId))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newItem.ItemId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.AddMarkupContent(17, "<label>\r\n            Item Name:\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                newItem.ItemName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItem.ItemName = __value, newItem.ItemName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newItem.ItemName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label>\r\n            Item Description:\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                newItem.ItemDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItem.ItemDescription = __value, newItem.ItemDescription))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newItem.ItemDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.AddMarkupContent(37, "<label>\r\n            Item Category:\r\n        </label>\r\n        ");
                __Blazor.KanionStats.Components.Ejercicios.Items.CreateItemComponent.TypeInference.CreateInputSelect_0(__builder2, 38, 39, "form-control", 40, 
#nullable restore
#line 27 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                  newItem.CategoryId

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newItem.CategoryId = __value, newItem.CategoryId)), 42, () => newItem.CategoryId, 43, (__builder3) => {
                    __builder3.AddMarkupContent(44, "\r\n");
#nullable restore
#line 28 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
             foreach (var loadedCategory in categories)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(45, "                ");
                    __builder3.OpenElement(46, "option");
                    __builder3.AddAttribute(47, "value", 
#nullable restore
#line 30 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                loadedCategory.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(48, 
#nullable restore
#line 30 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                                            loadedCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n");
#nullable restore
#line 31 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(50, "        ");
                }
                );
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "button");
                __builder2.AddAttribute(55, "value", "Agregar producto");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"
                                                            SaveProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\projects\Learning\004Blazor\KanionStats\Components\Ejercicios\Items\CreateItemComponent.razor"

    ItemEntity newItem = new ItemEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = categoryService.CategoryList();
    }


    private void SaveProduct()
    {
        itemCreateService.CreateItem(newItem);
        NavManager.NavigateTo("products/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Category categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private B_Item itemCreateService { get; set; }
    }
}
namespace __Blazor.KanionStats.Components.Ejercicios.Items.CreateItemComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591