#pragma checksum "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01214f459c6a3f7ca0c7dd796a2efcb234f8b278"
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
    public partial class InstructionInputTextArea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "code-area-container");
            __builder.AddMarkupContent(2, "<h4>Instruction Input:</h4>\r\n\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "type", "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "disabled", 
#nullable restore
#line 8 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                              CanEdit

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                                                  CompileInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<span class=\"oi oi-book\"></span>\r\n        Compile\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "btn btn-warning");
            __builder.AddAttribute(13, "disabled", 
#nullable restore
#line 12 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                              !CanEdit

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                                                   RegisterEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<span class=\"oi oi-document\"></span>\r\n        Edit\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "textarea");
            __builder.AddAttribute(18, "disabled", 
#nullable restore
#line 16 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                         InputDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "id", "instructionInputTextArea");
            __builder.AddAttribute(20, "placeholder", "Enter Instructions Here...");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                                             InputTextGiven

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputTextGiven = __value, InputTextGiven));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "code-area-container");
            __builder.AddMarkupContent(26, "<h4>Execution Instructions:</h4>\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-success");
            __builder.AddAttribute(30, "disabled", 
#nullable restore
#line 21 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                             ExecutionManager.EndOfInstructionSet()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                                                                               ExecuteInstruction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<span class=\"oi oi-media-play\"></span> Execute\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "ul");
            __builder.AddAttribute(35, "class", "list-group executing-instruction-list");
#nullable restore
#line 25 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
         if (!ExecutionManager.InstructionManager.Instructions.Any())
        {
            // fill table with empty data
            for (int i = 0; i < 5; i++)
            {
                var placeHolderText = "";
                if (i == 0)
                {
                    placeHolderText = "Compile Instructions to Fill Execution List.";
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "list-group-item");
            __builder.AddContent(38, 
#nullable restore
#line 36 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                     placeHolderText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
            }
        }
        else
        {
            var i = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
             foreach (var instruction in ExecutionManager.InstructionManager.Instructions)
            {
                var placeHolderListItemClass = "list-group-item";
                if (ExecutionManager.InstructionManager.InstructionIndex == i)
                {
                    placeHolderListItemClass = placeHolderListItemClass + " next-instruction";
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", 
#nullable restore
#line 50 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                placeHolderListItemClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, 
#nullable restore
#line 51 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                         StringifyInstruction(instruction)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, ";\r\n                        &nbsp;&nbsp;&nbsp;&nbsp;\r\n                        ");
            __builder.AddContent(43, 
#nullable restore
#line 53 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                         GetCodeRepresentationOfInstruction(instruction)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, ";\r\n                        \r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                    
                i++;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
       
    private string InputTextGiven;

    public bool InputDisabled = false;

    public bool CanEdit = false;

    private void CanEditToggle()
    {
        CanEdit = !CanEdit;
    }

    public void CompileInput()
    {
        ExecutionManager.InstructionManager.ProcessInstructions(InputTextGiven);
        InputDisabled = !InputDisabled;
        RegisterState.ResetRegisters = true;
        MemoryState.ResetMemory = true;
        CanEditToggle();
        RegisterState.RegistersStateChanged();
        MemoryState.MemoryStateChanged();
    }

    private void RegisterEdit()
    {
        InputDisabled = !InputDisabled;
        CanEditToggle();
    }

    private string StringifyInstruction(ApprovedInstruction instruction)
    {
        return ExecutionManager.InstructionManager.StringifyInstruction(instruction);
    }

    private string GetCodeRepresentationOfInstruction(ApprovedInstruction instruction) 
    {
        return ExecutionManager.GetBinaryExecutionRepresentation(instruction);
    }

    public void ExecuteInstruction()
    {
        ExecutionManager.ExecuteNextIntsruction();
        RegisterState.RegistersStateChanged();
        MemoryState.MemoryStateChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MemoryState MemoryState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegisterState RegisterState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExecutionManager ExecutionManager { get; set; }
    }
}
#pragma warning restore 1591
