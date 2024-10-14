using RiverBooks.Books.DataTransfer;

namespace RiverBooks.Books.Abstractions;

internal interface IBooksService
{
    Task<IEnumerable<BookDto>> GetAllAsync();
}