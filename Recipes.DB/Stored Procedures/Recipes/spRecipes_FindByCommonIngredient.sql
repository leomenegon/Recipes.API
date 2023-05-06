CREATE PROCEDURE [dbo].[spRecipes_FindByCommonIngredient]
	@CommonIngredientId INT
AS
BEGIN
	SELECT r.[Id], r.[Name], r.[Description] FROM [dbo].[Recipes] r
	INNER JOIN [dbo].[Ingredients] i ON r.[Id] = i.[RecipeId]
	WHERE r.[Deleted] = 0 AND i.[Deleted] = 0
	AND i.[CommonIngredientId] = @CommonIngredientId
END