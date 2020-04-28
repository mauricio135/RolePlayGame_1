using System;
using System.Collections;
//se agrega Elemento Armadura, con un Nombre y una defensa,este elemento da 0 de ataque y si su defensa es negativa se settea a 0
namespace RolePlayGame_1.Library
{
    public class Armadura : IElemento
        {
           public Armadura (string nombre)
            {
                this.Nombre=nombre;
                
            }
            public string Nombre{get;set;}
            public int Ataque=0;
           
            public int Defensa{get;}=10;
            
            public string GetTextToPrint()
        {
            return ($"La armadura {this.Nombre} tiene {this.Ataque}  ataque y {this.Defensa} de defensa ");
        }         
    }  
} 