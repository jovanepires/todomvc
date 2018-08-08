namespace TodoMVC.Models
{
    public class ItemTodo
    {
        public ItemTodo(string title, bool completed)
        {
            this.Title = title;
            this.Completed = completed;
        }

        public string Title { get; set; }

        public bool Completed { get; set; }
    }
}