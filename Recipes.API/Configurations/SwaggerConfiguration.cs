using Mapster;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Recipes.API.Configurations;

public static class SwaggerConfiguration
{
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Recipes API",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Leonardo Menegon",
                    Email = "leo.menegon3@gmail.com",
                    Url = new Uri("https://www.linkedin.com/in/leonardo-menegon-r/")
                },
                Description = "Fiz a API utlizando ASP.NET Core 6 com SQL Server e Dapper como ORM. "
                + "Tentei utilizar diferentes abordagens em alguns processos como prova de conceito. "
                + "Agradeço a oportunidade e espero que gostem!"
            });

            var xmlFile = "Recipes.API.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            c.IncludeXmlComments(xmlPath);
        });
    }
}