using System;
using Program;

namespace RolePlayGame_1.library
{
    public class PrintDementor
    {
        public static void ConsolePrintDementor(Dementor dementor)
        {
            Console.WriteLine(dementor.GetTextToPrint());
        }
    }
}