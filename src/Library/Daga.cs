using System;

namespace RolePlayGame_1.Library
{
    public class Daga: IElemento
    {
        public int Ataque { get; } = 20;
        public int Defensa { get; } = 8;
        public string Nombre { get; set; }

        public Daga (string nombre)
        {
            this.Nombre = nombre;
        }
        
        public string GetTextToPrint()
        {
            return ($"Daga: {this.Nombre}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
        }
    }
    
}