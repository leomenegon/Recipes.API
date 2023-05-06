CREATE PROCEDURE [dbo].[spIngredients_GetByRecipe]
	@RecipeId INT
AS
BEGIN
	SELECT [Id], [RecipeId], [Order], [Description] FROM [dbo].[Ingredients]
	WHERE [Deleted] = 0 AND [RecipeId] = @RecipeId
	ORDER BY [Order]
END