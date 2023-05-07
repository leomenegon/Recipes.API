using Recipes.API.Services;
using Recipes.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Recipes.API;

public static class Api
{
    public static WebApplication MapApi(this WebApplication app)
    {
        app.MapGet("/recipes", GetAllRecipes);
        app.MapGet("/recipes/{id}", GetRecipe);
        app.MapPost("/recipes", CreateRecipe);
        app.MapPut("/recipes", UpdateRecipe);
        app.MapDelete("/recipes/{id}", DeleteRecipe);
        app.MapGet("/recipes/search/{query}", FindRecipe);
        app.MapGet("/recipes/search/common-ingredient/{commonIngredientId}", FindRecipeByCommonIngredient);

        app.MapGet("/common-ingredients", GetAllCommonIngredients);
        app.MapPost("/common-ingredients", CreateCommonIngredient);

        return app;
    }

    public static async Task<IResult> GetAllRecipes(RecipeService service)
    {
        var response = await service.GetAll();

        return Results.Ok(response);
    }
    
    public static async Task<IResult> GetRecipe(RecipeService service, int id)
    {
        var response = await service.Get(id);

        return Results.Ok(response);
    }

    public static async Task<IResult> CreateRecipe(RecipeService service, CreateRecipeRequestDto dto)
    {
        var response = await service.Create(dto);

        return Results.Created($"/recipes/{response.Recipe.Id}", response);
    }
    
    public static async Task<IResult> UpdateRecipe(RecipeService service, UpdateRecipeRequestDto dto)
    {
        var response = await service.Update(dto);

        return Results.Ok(response);
    }
    
    public static async Task<IResult> DeleteRecipe(RecipeService service, int id)
    {
        await service.Delete(id);

        return Results.NoContent();
    }

    public static async Task<IResult> FindRecipe(RecipeService service, string query)
    {
        var response = await service.FindByNameAndDescription(query);

        return Results.Ok(response);
    }
    
    public static async Task<IResult> FindRecipeByCommonIngredient(RecipeService service, int commonIngredientId)
    {
        var response = await service.FindByCommonIngredient(commonIngredientId);

        return Results.Ok(response);
    }

    public static async Task<IResult> GetAllCommonIngredients(CommonIngredientService service)
    {
        var response = await service.GetAll();

        return Results.Ok(response);
    }

    public static async Task<IResult> CreateCommonIngredient(CommonIngredientService service, CreateCommonIngredientDto dto)
    {
        var response = await service.Create(dto);

        return Results.Created($"/common-ingredients/{response.Id}", response);
    }
    
    public static async Task<IResult> UpdateCommonIngredient(CommonIngredientService service, CommonIngredientDto dto)
    {
        var response = await service.Update(dto);

        return Results.Ok(response);
    }

    public static async Task<IResult> DeleteCommonIngredient(CommonIngredientService service, int id)
    {
        await service.Delete(id);

        return Results.NoContent();
    }
}
