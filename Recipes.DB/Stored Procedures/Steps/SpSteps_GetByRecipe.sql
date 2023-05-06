CREATE PROCEDURE [dbo].[SpSteps_GetByRecipe]
	@RecipeId INT
AS
BEGIN
	SELECT [Id], [RecipeId], [Order], [Description] FROM [dbo].[Steps]
	WHERE [Deleted] = 0 AND [RecipeId] = @RecipeId
	ORDER BY [Order]
END