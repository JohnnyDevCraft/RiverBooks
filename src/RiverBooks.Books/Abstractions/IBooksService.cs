namespace RiverBooks.Books;

internal interface IBooksService
{
    Task<IEnumerable<BookDto>> GetAllAsync();
}