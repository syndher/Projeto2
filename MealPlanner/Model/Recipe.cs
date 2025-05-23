using System;
using System.Collections.Generic;

namespace MealPlanner.Model
{
    /// <summary>
    /// Implementation of IRecipe. 
    /// </summary>
    public class Recipe : IRecipe
    {

        public int CompareTo(IRecipe other)
        {
            other.Name.CompareTo(this.Name);
        }

        public string Name { get; }
        public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; }
        public double SuccessRate { get; }
    }
}