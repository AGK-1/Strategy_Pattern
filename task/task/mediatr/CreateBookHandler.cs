using MediatR;
using task.model;

namespace task.mediatr
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, Book>
    {
        private readonly List<Book> _books;

        public CreateBookHandler()
        {
            _books = new List<Book>();
        }

        public Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Id = _books.Count + 1,
                Title = request.Title,
                Description = request.Description,
                BookGenre = request.BookGenre,
                Created = DateTime.UtcNow,
                Updated = DateTime.UtcNow
            };

            _books.Add(book);

            return Task.FromResult(book);
        }
    }
}
