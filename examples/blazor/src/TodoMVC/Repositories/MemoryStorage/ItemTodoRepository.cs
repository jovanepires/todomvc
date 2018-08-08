using System;
using System.Linq;
using TodoMVC.Models;
using TodoMVC.Repositories;
using System.Collections.Generic;

namespace TodoMVC.Repositories.MemoryStorage
{
    public class ItemTodoRepository : IItemTodoRepository
    {
        private List<ItemTodo> _Items = new List<ItemTodo>();

        public ItemTodo Get(string title)
        {
            return this._Items.FirstOrDefault(o => o.Title.Equals(title));
        }

        public bool Delete(string title)
        {
            // The number of elements removed from the List
            return this._Items.RemoveAll(o => o.Title.Equals(title)) != 0;
        }

        public ItemTodo Save(ItemTodo item)
        {
            var _item = this.Get(item.Title);

            if (_item != null)
            {
                _item.Completed = item.Completed;
            }
            else {

                this._Items.Add(item);
            }

            return item;
        }

        public IEnumerable<ItemTodo> List(string filter)
        {
            if (!string.IsNullOrEmpty(filter) && filter.Equals("active")) {
                return this._Items.Where(o => !o.Completed);
            }

            if (!string.IsNullOrEmpty(filter) && filter.Equals("completed")) {
                return this._Items.Where(o => o.Completed);
            }

            return this._Items;
        }
    }    
}