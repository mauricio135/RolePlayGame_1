using System;
using RolePlayGame_1.Library;


namespace RolePlayGame_1.library
{
    public class PrintMago
    {
        public static void ConsolePrintDementor(Mago mago)
        {
            Console.WriteLine(mago.GetTextToPrint());
        }
    }
}