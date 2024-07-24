using MediatR;
using task.model;

namespace task.mediatr
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, Book>
    {
        private readonly List<Book> _books;

        public GetBookByIdHandler()
        {
            _books = new List<Book>();
        }

        public Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = _books.FirstOrDefault(b => b.Id == request.Id);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            return Task.FromResult(book);
        }
    }
}
