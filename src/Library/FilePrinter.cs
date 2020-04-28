using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    ////se define clase FilePrinter que implementa el tipo IPrintRecipe
    public class FilePrinter : IPrintRecipe
    {
        public void PrintRecipe(Recipe recipe)
        { 
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());    
        }
    }
}