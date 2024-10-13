using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

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
