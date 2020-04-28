using System;

namespace Full_GRASP_And_SOLID.Library
{
    //se define clase ConsolePrinter que implementa el tipo IPrintRecipe
    public class ConsolePrinter : IPrintRecipe
    {
        public void PrintRecipe(Recipe recipe)
        { 
            Console.WriteLine(recipe.GetTextToPrint());    
        }
    }
}