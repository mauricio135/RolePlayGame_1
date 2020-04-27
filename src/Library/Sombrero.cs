using System;

namespace RolePlayGame_1.Library
{
    public class Sombrero: IElementoMagico
    {
        public int Ataque { get; } = 0;
        public int Defensa { get; } = 15;
        public string Nombre { get; set; }

        public Sombrero (string nombre)
        {
            this.Nombre = nombre;
        }
        
        public string GetTextToPrint()
        {
            return ($"Sombrero: {this.Nombre}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
        }
    }
    
}