using Recipes.API.Models;

namespace Recipes.API.Repositories.Data;

public class IngredientData
{
    private readonly DataAccess _db;

    public IngredientData(DataAccess db)
    {
        _db = db;
    }

    public async Task<IngredientModel?> GetByRecipe(int recipeId)
    {
        var query = await _db.LoadData<IngredientModel, dynamic>("dbo.spIngredients_GetByRecipe", new { RecipeId = recipeId });

        return query.FirstOrDefault();
    }
}