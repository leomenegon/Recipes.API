namespace Recipes.API.ViewModels;

public record CommonIngredientDto(int id, string name);

public record CreateCommonIngredientDto(string name);