CREATE PROCEDURE [dbo].[spRecipes_FindByNameAndDescription]
	@TextQuery NVARCHAR(50)
AS
BEGIN
	SELECT DISTINCT [Id], [Name], [Description] FROM [dbo].[Recipes]
	WHERE [Deleted] = 0 
	AND (LOWER([Name]) LIKE LOWER('%'+@TextQuery+'%') OR LOWER([Description]) LIKE LOWER('%'+@TextQuery+'%'))
-- Devido a base ser uma localdb tive que adaptar para LIKE. Deve ser substituido por um full text search.	
END