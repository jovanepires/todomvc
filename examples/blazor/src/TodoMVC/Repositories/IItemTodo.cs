using System;
using TodoMVC.Models;
using System.Collections.Generic;

namespace TodoMVC.Repositories 
{
    public interface IItemTodoRepository
    {
        ItemTodo Get(string title);

        bool Delete(string title);

        ItemTodo Save(ItemTodo item);

        IEnumerable<ItemTodo> List(string filter);
    }    
}