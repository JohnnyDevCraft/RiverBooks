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
    Task<IEnumerable<Book>> GetAllAsync();
}

internal record Book(int Id, string Title);

internal class BooksService : IBooksService
{
    public async Task<IEnumerable<Book>> GetAllAsync()
    {
        await Task.Delay(1000);
        return new List<Book>
        {
            new(1, "Book 1"),
            new(2, "Book 2"),
            new(3, "Book 3"),
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
