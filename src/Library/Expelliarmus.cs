using System;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{
/* Se agrega un hechizo que implementa la interfaz IHechizo, aplicamos polimorfismo, ya que cada hechizo implementa en su clase la forma de imprimirse.
*/
    public class Expelliarmus: IHechizo
    {
        public string Nombre { get; } = "Expelliarmus";
        public string GetTextToPrint()
        {
            return ($"Hechizo: {this.Nombre}");
        }

    }

}