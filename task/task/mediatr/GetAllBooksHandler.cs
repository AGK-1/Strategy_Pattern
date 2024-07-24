using MediatR;
using task.model;

namespace task.mediatr
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        private readonly List<Book> _books;

        public GetAllBooksHandler()
        {
            _books = new List<Book>();
        }

        public Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult((IEnumerable<Book>)_books);
        }
    }
}
