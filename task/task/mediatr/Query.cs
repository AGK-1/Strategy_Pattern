using MediatR;
using task.model;

namespace task.mediatr
{
  
    public class GetBookByIdQuery : IRequest<Book>
    {
        public long Id { get; set; }
    }

    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {
    }
}
