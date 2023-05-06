using Recipes.API.Models;

namespace Recipes.API.Repositories.Data;

public class StepData
{
    private readonly DataAccess _db;

    public StepData(DataAccess db)
    {
        _db = db;
    }

    public async Task<StepModel?> GetByRecipe(int recipeId)
    {
        var query = await _db.LoadData<StepModel, dynamic>("dbo.spSteps_GetByRecipe", new { RecipeId = recipeId });

        return query.FirstOrDefault();
    }
}