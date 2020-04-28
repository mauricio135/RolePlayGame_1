using System;
using System.Collections;

//Se crea Tipo IElemento donde se estipulan como se componen los Elementos 
namespace RolePlayGame_1.Library
{
    public interface IElemento
    {
        string Nombre { get;set;}
        int Ataque { get;set;}
        int Defensa { get;set;}
        string GetTextToPrint();

    }
    
}