// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MemoryArea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\kechalup\source\repos\AdvancedConputerArchitectureHW2\Pages\MemoryArea.razor"
       
    public string GetMemoryChangeCLass(bool justChanged)
    {
        return (justChanged) ? "just-changed" : "";
    }

    public void RefreshMe()
    {
        StateHasChanged();

        if (MemoryState.ResetMemory)
        {
            MemoryManager.ResetMemory();
            MemoryState.ResetMemory = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MemoryManager MemoryManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MemoryState MemoryState { get; set; }
    }
}
#pragma warning restore 1591
