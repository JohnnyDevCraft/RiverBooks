using FastEndpoints;
using RiverBooks.Books.Abstractions;
using RiverBooks.Books.Extensions.Mappers;
using RiverBooks.Books.ResponseTypes;

namespace RiverBooks.Books.Endpoints;

internal class ListBooksEndpoint(IBooksService booksService): EndpointWithoutRequest<ListBooksResponse>
{
    public override void Configure()
    {
        Get(Constants.Endpoints.GetAll);
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var books = await booksService.GetAllAsync();
        Response.Books = books.Select(book => book.ToBookResult()).ToList();
        return;
    }
}