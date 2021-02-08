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
    public partial class InstructionInputTextArea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
       
    private string InputTextGiven;

    //private ProvidedInstructionManager InstructionManager = new ProvidedInstructionManager();


    public bool InputDisabled = false;

    public void CompileInput(MouseEventArgs e)
    {
        InstructionManager.FilterInstructions(SplitInstructions(InputTextGiven));
        InputDisabled = !InputDisabled;
        InvokeAsync(() => StateHasChanged()); ;
    }

    private List<string> SplitInstructions(string instructionsGiven)
    {
        var instructions = InputTextGiven.Split(new Char[] { ';', '\n' }).ToList();
        instructions.RemoveAll(i => string.IsNullOrEmpty(i));
        return instructions;
    }

    private string StringifyInstruction(ApprovedInstruction instruction)
    {
        var stringInstruction = instruction.Operation;
        instruction.Arguements.ForEach(arg => stringInstruction = stringInstruction + " " + arg);
        return stringInstruction;
    }

    public void Execute() 
    {
        ExecutionManager.ExecuteInstruction(InstructionManager.Instructions.FirstOrDefault());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExecutionManager ExecutionManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProvidedInstructionManager InstructionManager { get; set; }
    }
}
#pragma warning restore 1591
