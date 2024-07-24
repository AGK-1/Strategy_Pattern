namespace task.model
{
    public enum BookGenre
    {
        None = 0,
        Fable = 1,
        Fiction = 2,
        Horror = 3,
        Mystery = 4
    }

    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BookGenre BookGenre { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
