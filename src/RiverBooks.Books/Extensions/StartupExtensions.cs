using Microsoft.Extensions.DependencyInjection;
using RiverBooks.Books.Abstractions;
using RiverBooks.Books.Implimentations;

namespace RiverBooks.Books.Extensions;

public static class StartupExtensions
{
    public static void AddBooksModule(this IServiceCollection services)
    {
       services.AddScoped<IBooksService, BooksService>();
    }

}
