using System;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{
    public class Expelliarmus: IHechizo
    {
        public string Nombre { get; } = "Expelliarmus";
        public string GetTextToPrint()
        {
            return ($"Hechizo: {this.Nombre}");
        }

    }

}