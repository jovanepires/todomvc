#pragma checksum "/Users/jovanepires/workspace/todomvc/examples/blazor/TodoMVC/Shared/MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded7d744c7d23f2275abd279aaac9c532ff85d0e"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoMVC.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using TodoMVC;
    using TodoMVC.Shared;
    using TodoMVC.Models;
    using TodoMVC.Repositories;
    using TodoMVC.Repositories.MemoryStorage;
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddContent(0, Body);
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
