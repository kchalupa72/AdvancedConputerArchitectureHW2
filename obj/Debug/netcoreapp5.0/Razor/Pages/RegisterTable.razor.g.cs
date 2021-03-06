#pragma checksum "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01486c4d3ff502e41167c2dca960e006e908e95d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    public partial class RegisterTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Registers:</h4>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table feedback");
            __builder.AddMarkupContent(3, "<thead><tr><th scope=\"col\">Register</th>\n            <th scope=\"col\">Decimal</th>\n            <th scope=\"col\">Binary</th>\n            <th scope=\"col\">Hex</th></tr></thead>\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 16 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
         foreach (var register in registers.RegisterRepo)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "class", 
#nullable restore
#line 18 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
                        GetRegisterChangeClass(register.Value.JustChanged)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "scope", "row");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
                                 register.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 20 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
                     register.Value.Value.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 21 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
                     Convert.ToString(register.Value.Value, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 22 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
                      "0x" + register.Value.Value.ToString("X8")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\RegisterTable.razor"
       

    public void RefreshMe()
    {
        StateHasChanged();

        if (RegisterState.ResetRegisters)
        {
            registers.ResetRegisterValues();
            RegisterState.ResetRegisters = false;
        }
    }

    public string GetRegisterChangeClass(bool justChanged)
    {
        return (justChanged) ? "just-changed" : "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegisterState RegisterState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegisterManager registers { get; set; }
    }
}
#pragma warning restore 1591
