#pragma checksum "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216d6bce078678c2420eab5a776cea99f10462b5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kenne\source\repos\BlazorApp\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    public partial class InstructionTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "css-container code-area-container");
            __builder.AddMarkupContent(2, "\r\n    Instructions:\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "css-container info-area-container");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table feedback");
            __builder.AddMarkupContent(7, "<thead><tr><th scope=\"col\">Instruction</th>\r\n                    <th scope=\"col\">Description</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 12 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor"
                 foreach (var instruction in GetInstructions())
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "scope", "row");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor"
                                         instruction.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor"
                             instruction.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionTable.razor"
           
        private InstructionSet instructionSet = new InstructionSet();

        private Dictionary<string, string> GetInstructions()
        {
            return instructionSet.Instructions;
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
