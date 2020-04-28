using System;
using RolePlayGame_1.Library;
//Se Agrega PrintPersonaje 

namespace RolePlayGame_1.Library
{
    public class PrintPersonaje 
    {
        public void ConsolePrint(IPersonaje personaje)
        {
            Console.WriteLine(personaje.GetTextToPrint());

        }
    }
}