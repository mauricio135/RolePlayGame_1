using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public interface IElemento
    {
        string Nombre { get;}
        int Ataque { get;}
        int Defensa { get;}
        string GetTextToPrint();


    }
    
}