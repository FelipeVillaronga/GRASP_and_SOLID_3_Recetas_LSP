using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*Esta clase tiene como única responsabilidad la impresión de un archivo de texto de la receta*/
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}
