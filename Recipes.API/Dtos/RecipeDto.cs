namespace Recipes.API.ViewModels;

public record RecipeDto(
    int id,
    string name,
    string description);

public record FullRecipeDto(
    int id,
    string name,
    string description,
    IList<IngredientDto> ingredients,
    IList<StepDto> steps);