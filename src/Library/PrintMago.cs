using System;
using RolePlayGame_1.Library;


namespace RolePlayGame_1.library
{
//Por SRP decidimos crear una clase que tenga la responsabilidad de imprimir los datos del mago
    public class PrintMago
    {
        public static void ConsolePrintDementor(Mago mago)
        {
            Console.WriteLine(mago.GetTextToPrint());
        }
    }
}