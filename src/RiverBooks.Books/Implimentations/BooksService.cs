using RiverBooks.Books.Abstractions;
using RiverBooks.Books.DataTransfer;

namespace RiverBooks.Books.Implimentations;

internal class BooksService : IBooksService
{
    public async Task<IEnumerable<BookDto>> GetAllAsync()
    {
        await Task.Delay(1000);
        return new List<BookDto>
        {
            new BookDto(1, "The Fellowship of the Ring", "J.R.R. Tolkien"),
            new BookDto(2, "The Two Towers", "J.R.R. Tolkien"),
            new BookDto(3, "The Return of the King", "J.R.R. Tolkien")
        };
    }
}