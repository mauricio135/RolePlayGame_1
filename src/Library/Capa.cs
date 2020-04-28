using System;

namespace RolePlayGame_1.Library
{

/* Capa implementa la interfaz IElemento, ya que esta es el molde para todos los elementos. 
Cada elemento se imprime en una operación polimórfica como cada elemento se deba imprimir.
*/
    public class Capa: IElemento
    {
        public int Ataque { get; } = 20;
        public int Defensa { get; } = 8;
        public string Nombre { get; set; }

        public Capa (string nombre)
        {
            this.Nombre = nombre;
        }
/*
Aplicamos SRP, los Elementos tienen una única responsabilidad
y la clase tiene una unica razon para cambiar. En este caso la forma de imprimirse
*/ 
        public string GetTextToPrint()
        {
            return ($"Capa: {this.Nombre}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
        }
    }
    
}