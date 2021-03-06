#pragma checksum "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f141c4642299d0487c8e34b7f489074a9c9bae"
// <auto-generated/>
#pragma warning disable 1591
namespace Lesson4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Lesson4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\_Imports.razor"
using Lesson4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
using Lesson4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
using Lesson4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Todos</h1>");
#nullable restore
#line 7 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
 if (todos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
}
else if (!todos.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 18 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>User ID</th> <th>Todo ID</th> <th>Title</th> <th>Completed?</th><th>Remove</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 28 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
         foreach (var item in todos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 31 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
                     item.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(10, " ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
                                           item.TodoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(13, " ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
                                                                 item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
                                                                                      item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
                                    () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\User\RiderProjects\SolutionExample\Lesson4\Pages\Todos.razor"
       

    private IList<ToDo> todos;

    protected override async Task OnInitializedAsync()
    {
        todos = TodoData.GetTodos();
    }

    private void RemoveTodo(int todoId)
    {
        ToDo todoToRemove = todos.First(t => t.TodoId == todoId);
        TodoData.RemoveTodo(todoId);
        todos.Remove(todoToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
#pragma warning restore 1591
