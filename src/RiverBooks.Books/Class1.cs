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


public static class StartupExtensions
{
    public static void AddBooksModule(this IServiceCollection services)
    {
       
    }

    public static void UseBooksModule(this WebApplication app)
    {
        app.MapGet(Constants.Endpoints.GetAll,  () => new List<object>()
        {
            new { Id = 1, Title = "Book 1" },
            new { Id = 2, Title = "Book 2" },
            new { Id = 3, Title = "Book 3" },
        });
    }
}
