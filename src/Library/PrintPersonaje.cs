using System;
//Se Agrega PrintPersonaje 

namespace RolePlayGame_1
{
    public class PrintPersonaje : IPersonaje
    {
        public void PrintPersonaje(IPersonaje personaje)
        {
            Console.WriteLine(personaje.GetTextToPrint());

        }
    }
}