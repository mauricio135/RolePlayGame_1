using System;

namespace RolePlayGame_1.Library
{
    public class Capa: IElemento
    {
        public int Ataque { get; } = 20;
        public int Defensa { get; } = 8;
        public string Nombre { get; set; }

        public Capa (string nombre)
        {
            this.Nombre = nombre;
        }
        
        public string GetTextToPrint()
        {
            return ($"Capa: {this.Nombre}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
        }
    }
    
}