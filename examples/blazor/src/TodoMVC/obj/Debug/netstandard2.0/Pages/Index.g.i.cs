#pragma checksum "/Users/jovanepires/workspace/todomvc/examples/blazor/src/TodoMVC/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ab180f6e5238332f56fcd6bbbda7663dfb8bdc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoMVC.Pages
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/{Filter}")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 55 "/Users/jovanepires/workspace/todomvc/examples/blazor/src/TodoMVC/Pages/Index.cshtml"
            
	[Parameter]
	private string Filter { get; set; }

	private string Title = null;
	private bool ToggleAll = true;
    private static ItemTodoRepository Repository = new ItemTodoRepository();
	private List<ItemTodo> Items = null;

	protected override void OnInit()
    {
        UpdateItemsList(); 
    }

	private void Navigate(string filter)
    {
        UriHelper.NavigateTo($"/{filter}");
		Filter = filter;
		StateHasChanged();
		UpdateItemsList(); 
    }

	protected void NewTodo(UIKeyboardEventArgs ev, string title)
	{
		if (ev.Key.Equals("Enter", StringComparison.OrdinalIgnoreCase)) 
		{
            Repository.Save(new ItemTodo(title, false));
			Title = null;
			UpdateItemsList(); 
		}
	}

	void RemoveTodo(string title) 
	{
		Repository.Delete(title);
		UpdateItemsList();
	}

	void ClearCompletedTodos() 
	{
		Items.Where(o => o.Completed).ToList().ForEach(o => Repository.Delete(o.Title));
		UpdateItemsList();
	}

	void ToggleAllTodos(bool flag) 
	{
		Items.ForEach(o => Repository.Save(new ItemTodo(o.Title, flag)));
		ToggleAll = !flag;
		UpdateItemsList();
	}

	void TodoIsCompleted(string title)
    {
        Repository.Save(new ItemTodo(title, true));
		UpdateItemsList();
    }

	void UpdateItemsList() 
	{
		Items = Repository.List(Filter).ToList();
	}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
