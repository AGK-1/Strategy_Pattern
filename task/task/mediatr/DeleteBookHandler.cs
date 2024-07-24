using MediatR;
using task.mediatr;
using task.model;

public class DeleteBookHandler : IRequestHandler<Deletecomand>
{
    private readonly List<Book> _books;

    public DeleteBookHandler()
    {
        _books = new List<Book>();
    }

    public Task<Unit> Handle(Deletecomand request, CancellationToken cancellationToken)
    {
        var book = _books.FirstOrDefault(b => b.Id == request.Id);

        if (book == null)
        {
            throw new Exception("Book not found");
        }

        _books.Remove(book);

        return Task.FromResult(Unit.Value);
    }

    //Task IRequestHandler<Deletecomand>.Handle(Deletecomand request, CancellationToken cancellationToken)
    //{
    //    var book = _books.FirstOrDefault(b => b.Id == request.Id);

    //    if (book == null)
    //    {
    //        throw new Exception("Book not found");
    //    }

    //    _books.Remove(book);

    //    return Task.FromResult(Unit.Value);
    //}

   
}
