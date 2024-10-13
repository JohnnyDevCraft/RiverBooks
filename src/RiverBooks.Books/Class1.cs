using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

internal static class Constants
{
    internal static class Endpoints
    {
        internal const string GetAll = "api/books";
        internal const string GetById = "api/books/{0}";
        internal const string Create = "api/books";
        internal const string Update = "api/books/{0}";
        internal const string Delete = "api/books/{0}";
    }
}

internal interface IBooksService
{
    Task<IEnumerable<BookDto>> GetAllAsync();
}

internal record BookDto(int Id, string Title, string Author);

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
public static class StartupExtensions
{
    public static void AddBooksModule(this IServiceCollection services)
    {
       services.AddScoped<IBooksService, BooksService>();
    }

    public static void UseBooksModule(this WebApplication app)
    {
        app.MapGet(Constants.Endpoints.GetAll, (IBooksService booksService) => booksService.GetAllAsync())
            .WithName("GetAllBooks");
    }
}
