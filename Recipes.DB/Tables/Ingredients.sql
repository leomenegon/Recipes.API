CREATE TABLE [dbo].[Ingredients]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
    [RecipeId] INT NOT NULL,
    [CommonIngredientId] INT,
    [Order] SMALLINT NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [Deleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT PK_Ingredients PRIMARY KEY CLUSTERED (Id),
    CONSTRAINT FK_Ingredients_Recipes FOREIGN KEY (RecipeId) REFERENCES Recipes (Id),
    CONSTRAINT FK_Ingredients_CommonIngredients FOREIGN KEY (CommonIngredientId) REFERENCES CommonIngredients (Id)
)