using System;


namespace RolePlayGame_1.library
{

//SRP, le damos a PrintDementor la responsabilidad de imprimir los datos del dementor.
    public class PrintDementor
    {
        public static void ConsolePrintDementor(Dementor dementor)
        {
            Console.WriteLine(dementor.GetTextToPrint());
        }
    }
}