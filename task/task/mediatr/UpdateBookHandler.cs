using MediatR;
using task.model;

namespace task.mediatr
{
    public class UpdateBookHandler : IRequestHandler<Updatecomand, Book>
    {
        private readonly List<Book> _books;

        public UpdateBookHandler()
        {
            _books = new List<Book>();
        }

        public Task<Book> Handle(Updatecomand request, CancellationToken cancellationToken)
        {
            var book = _books.FirstOrDefault(b => b.Id == request.Id);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            book.Title = request.Title;
            book.Description = request.Description;
            book.BookGenre = request.BookGenre;
            book.Updated = DateTime.UtcNow;

            return Task.FromResult(book);
        }
    }
}
