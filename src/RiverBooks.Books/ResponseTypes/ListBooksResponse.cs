using RiverBooks.Books.ResultTypes;

namespace RiverBooks.Books.ResponseTypes;

public class ListBooksResponse
{
    public List<BookResult> Books { get; set; }
}