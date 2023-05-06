using Mapster;
using Recipes.API.Repositories.Data;
using Recipes.API.ViewModels;

namespace Recipes.API.Services;

public class CommonIngredientService
{
    private readonly CommonIngredientData _data;

    public CommonIngredientService(CommonIngredientData data)
    {
        _data = data;
    }

    public async Task<IEnumerable<CommonIngredientDto>> GetAll()
    {
        var commonIngredients = await _data.GetAll();

        return commonIngredients.Adapt<IEnumerable<CommonIngredientDto>>();
    }

    public async Task<CommonIngredientDto> Create(CommonIngredientDto dto)
    {

    }
}