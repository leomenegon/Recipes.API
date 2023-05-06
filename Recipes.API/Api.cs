using Recipes.API.Services;

namespace Recipes.API;

public static class Api
{
    public static WebApplication MapApi(this WebApplication app)
    {
        app.MapGet("/common-ingredients", (CommonIngredientService service) => service.GetAll());

        return app;
    }
}
