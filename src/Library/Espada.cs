using System;
using System.Collections;
using RolePlayGame_1.Library;
//se agrega Elemento Espada, con un Nombre y un ataque,este elemento da 0 de defensa y si su ataque es negativo se settea a 0

namespace RolePlayGame_1.Library
{

/* Espada implementa la interfaz IElemento, ya que esta es el molde para todos los elementos. 
Cada elemento se imprime en una operación polimórfica como cada elemento se deba imprimir.
*/
    public class Espada : IElemento
        {

            public Espada (string nombre)
            {
                this.Nombre=nombre;
            }
            public string Nombre{get;set;}
            
            public int Ataque {get;}=10;
            public int Defensa{get;}=0;
/*
Aplicamos SRP, los Elementos tienen una única responsabilidad
y la clase tiene una unica razon para cambiar. En este caso la forma de imprimirse
*/ 
            public string GetTextToPrint()
        {
            return ($"La Espada {this.Nombre} tiene {this.Ataque}  ataque y {this.Defensa} de defensa ");
        }         
    }  
} 