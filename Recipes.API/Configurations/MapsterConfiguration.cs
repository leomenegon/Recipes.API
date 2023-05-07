using Mapster;
using System.Reflection;

namespace Recipes.API.Configurations;

public static class MapsterConfiguration
{
    public static void ConfigureMapster(this IServiceCollection services)
    {
        //TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
    }
}