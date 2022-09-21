using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*Por principio SRP, la clase AllInOnePrinter no debe tener más de 1 razón
    En este programa inicialmente debía, preguntar por el destino, y realizar la impresión
    Por ello se crea una clase para cada tipo de impresión, así como también la interfaz IPrinter
    con el fin de que las instancias de las impresiones puedan operar polimorficamente mediante la interfaz
    Esta clase se encarga únicamente de imprimir la receta en la consola*/
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
