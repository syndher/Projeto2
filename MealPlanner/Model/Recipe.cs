using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace MealPlanner.Model
{
    /// <summary>
    /// Implementation of IRecipe. 
    /// </summary>
    public class Recipe : IRecipe
    {

        public int CompareTo(IRecipe other)
        {
            int value = 0;
            if (other.Name.CompareTo(this.Name) > 0)
            {
                value = 1;
            }
            else if (other.Name.CompareTo(this.Name) < 0)
            {
                value = -1;
            }
            return value;
        }

        public string Name { get; }
        public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; }
        public double SuccessRate { get; }
        
    }
}