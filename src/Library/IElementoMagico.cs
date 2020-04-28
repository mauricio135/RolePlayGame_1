using System;
using RolePlayGame_1.Library;


namespace RolePlayGame_1
{
/* Interfaz que sera el molde de todos los elementos magicos, que a su vez seran elementos, sus atributos comunes y el metodo donde se imprimen que luego 
cada elemento magico implementará en su clase, aplicando Polimorfismo
*/
    public interface IElementoMagico: IElemento
    {
        string Nombre { get; set; }
        int Ataque { get; }
        int Defensa { get; }
        string GetTextToPrint();
        
    }
    
}