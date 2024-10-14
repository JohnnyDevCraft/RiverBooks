using RiverBooks.Books.ResultTypes;

namespace RiverBooks.Books.ResponseTypes;

public class ListBooksResponse(List<BookResult> books)
{
    public List<BookResult> Books { get; set; } = books;
}