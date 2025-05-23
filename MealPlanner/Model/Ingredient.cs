using System;
using System.Collections.Generic;

namespace MealPlanner.Model
{
    /// <summary>
    /// Implementation of IIngredient. 
    /// </summary>
    public class Ingredient : IIngredient
    {
        public bool Equals(IIngredient other)
        {
            if (other.Name == this.Name && other.Type == this.Type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Name { get; }
        public string Type { get; }
    
    }
}