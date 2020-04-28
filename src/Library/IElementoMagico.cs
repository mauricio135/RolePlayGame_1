using System;
using RolePlayGame_1.Library;


namespace RolePlayGame_1
{
    public interface IElementoMagico: IElemento
    {
        string Nombre { get; set; }
        int Ataque { get; }
        int Defensa { get; }
        string GetTextToPrint();
        
    }
    
}