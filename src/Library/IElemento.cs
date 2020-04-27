using System;
using System.Collections;

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