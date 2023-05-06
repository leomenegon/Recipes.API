using Recipes.API.Repositories;
using Recipes.API.Repositories.Data;
using Recipes.API.Services;

namespace Recipes.API.Configurations;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
    {
        services.AddSingleton<DataAccess>();

        services.AddScoped<CommonIngredientService>();

        services.AddScoped<RecipeData>();
        services.AddScoped<StepData>();
        services.AddScoped<IngredientData>();
        services.AddScoped<CommonIngredientData>();

        return services;
    }
}