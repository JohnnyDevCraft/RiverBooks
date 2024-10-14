using RiverBooks.Books.DataTransfer;
using RiverBooks.Books.ResultTypes;

namespace RiverBooks.Books.Extensions.Mappers;

internal static class BookResultExtensions
{
    internal static BookResult ToBookResult(this BookDto bookDto)
    {
        return new BookResult(bookDto.Id, bookDto.Title, bookDto.Author);
    }
}