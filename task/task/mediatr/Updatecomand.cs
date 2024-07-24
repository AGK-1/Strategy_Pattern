using MediatR;
using task.model;

namespace task.mediatr
{
    public class Updatecomand : IRequest<Book>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
