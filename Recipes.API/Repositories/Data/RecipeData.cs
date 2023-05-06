using Recipes.API.Models;

namespace Recipes.API.Repositories.Data;

public class RecipeData
{
    private readonly DataAccess _db;

    public RecipeData(DataAccess db)
    {
        _db = db;
    }

    public async Task<RecipeModel?> Get(int id)
    {
        var query = await _db.LoadData<RecipeModel, dynamic>("dbo.spRecipes_Get", new { Id = id });

        return query.FirstOrDefault();
    }

    public async Task<IEnumerable<RecipeModel>> GetAll()
    {
        return await _db.LoadData<RecipeModel, dynamic>("dbo.spRecipes_GetAll", new { });
    }
    
    public async Task<IEnumerable<RecipeModel>> FindByNameAndDescription(string textQuery)
    {
        return await _db.LoadData<RecipeModel, dynamic>("dbo.spRecipes_FindByNameAndDescription", new { TextQuery = textQuery });
    }    

    public async Task<IEnumerable<RecipeModel>> FindByCommonIngredient(int commonIngredientId)
    {
        return await _db.LoadData<RecipeModel, dynamic>("dbo.spRecipes_FindByCommonIngredient", new { CommonIngredientId = commonIngredientId });
    }
}