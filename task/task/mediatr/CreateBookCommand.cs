using MediatR;
using task.model;

namespace task.mediatr
{
   
    public class CreateBookCommand : IRequest<Book>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
