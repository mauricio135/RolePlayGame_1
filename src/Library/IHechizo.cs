using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public interface IHechizo
    {
        string Nombre { get; }
        string GetTextToPrint();
        
    }
    
}