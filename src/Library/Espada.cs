using System;
using System.Collections;
//se agrega Elemento Espada, con un Nombre y un ataque,este elemento da 0 de defensa y si su ataque es negativo se settea a 0

namespace RolePlayGame_1.Library
{
    public class Espada : IElemento
        {

            public Espada (string nombre)
            {
                this.Nombre=nombre;
            }
            public string Nombre{get;set;}
            
            public int Ataque {get;}=10;
            public int Defensa=0;
           
            public string GetTextToPrint()
        {
            return ($"La Espada {this.Nombre} tiene {this.Ataque}  ataque y {this.Defensa} de defensa ");
        }         
    }  
} 