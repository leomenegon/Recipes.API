CREATE PROCEDURE [dbo].[spCommonIngredients_Insert]
	@Name NVARCHAR(50)
AS
BEGIN
	INSERT INTO [dbo].[CommonIngredients] ([Name])
	VALUES (@Name)
END