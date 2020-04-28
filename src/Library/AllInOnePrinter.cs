//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
//using System;
//using System.IO;

//---------------------------------------------------------------------------------
/*Usando el Patron Polymorfism, esta clase se elimina(la comento para no eliminarla y visualizar cambios), 
se crea la Interface IPrinter y las clases ConsolePrinter y FilePrinter
*/
//---------------------------------------------------------------------------------

/*
namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}
*/