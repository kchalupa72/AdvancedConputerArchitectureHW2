#pragma checksum "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d3d4c2842bb0221e3ef2e44664c5c8376ddef6"
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
            __builder.AddAttribute(1, "class", "html-container code-area-container");
            __builder.AddMarkupContent(2, "\r\n    Instruction Input:\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "type", "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                            CompileInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Compile");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "btn btn-warning");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                            (e => InputDisabled = !InputDisabled)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "textarea");
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 5 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                         InputDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "id", "instructionInputTextArea");
            __builder.AddAttribute(18, "placeholder", "Enter Instructions Here...");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
                                                                             InputTextGiven

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputTextGiven = __value, InputTextGiven));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.AddMarkupContent(23, @"<div class=""html-container code-area-container"">
    <ul class=""list-group executing-instruction-list"">
        <li class=""list-group-item"">Dapibus ac facilisis in</li>
        <li class=""list-group-item list-group-item-primary"">This is a primary list group item</li>
        <li class=""list-group-item list-group-item-secondary"">This is a secondary list group item</li>
    </ul>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\kenne\source\repos\BlazorApp\Pages\InstructionInputTextArea.razor"
       
    private string InputTextGiven;

    public bool InputDisabled = false;

    public void CompileInput(MouseEventArgs e) 
    {
        InputTextGiven = InputTextGiven + " TESTING ADDING TO STRING";
        var teststring = InputTextGiven;
        InputDisabled = !InputDisabled;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
