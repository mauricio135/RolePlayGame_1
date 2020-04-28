using System;
using System.Collections;

//se agrega Elemento Armadura, con un Nombre y una defensa,este elemento da 0 de ataque y si su defensa es negativa se settea a 0
namespace RolePlayGame_1.Library
{

/* Armadura implementa la interfaz IElemento, ya que esta es el molde para todos los elementos. 
Cada elemento se imprime en una operación polimórfica como cada elemento se deba imprimir.
*/
    public class Armadura : IElemento
        {
           public Armadura (string nombre)
            {
                this.Nombre=nombre;
                
            }
            public string Nombre{get;set;}
            public int Ataque{get;}=0;
           
            public int Defensa{get;}=10;
/*
Aplicamos SRP, los Elementos tienen una única responsabilidad
y la clase tiene una unica razon para cambiar. En este caso la forma de imprimirse
*/             
            public string GetTextToPrint()
        {
            return ($"La armadura {this.Nombre} tiene {this.Ataque}  ataque y {this.Defensa} de defensa ");
        }         
    }  
} 