﻿namespace Recipes.API.Models;

public class StepModel
{
    public int Id { get; set; }
    public int RecipeId { get; set; }
    public int Order { get; set; }
    public string? Description { get; set; }
}