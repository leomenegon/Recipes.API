using Recipes.API.Models;

namespace Recipes.API.Repositories.Data;

public class CommonIngredientData
{
    private readonly DataAccess _db;

    public CommonIngredientData(DataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<CommonIngredientModel>> GetAll()
    {
        return await _db.LoadData<CommonIngredientModel, dynamic>("dbo.spCommonIngredients_GetAll", new { });
    }
    
    public async Task Create(string name)
    {
        await _db.ExecuteCommand<dynamic>("dbo.spCommonIngredients_Insert", new { Name = name });
    }
}