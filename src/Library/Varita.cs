using System;

namespace RolePlayGame_1.Library
{
    public class Varita: IElemento
    {
        public int Ataque { get; } = 15;
        public int Defensa { get; } = 10;
        public string Nombre { get; set; }

        public Varita (string nombre)
        {
            this.Nombre = nombre;
        }
        
        public string GetTextToPrint()
        {
            return ($"Varita: {this.Nombre}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
        }
    }
    
}