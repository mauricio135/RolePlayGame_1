using System;
using System.Collections;
 
namespace RolePlayGame_1.Library
{
/* Interfaz que sera el molde de todos los elementos, sus atributos comunes y el metodo donde se imprimen que luego cada elemento implementará en su clase.
Aplicando Polimorfismo
*/
    public interface IElemento
    {
        string Nombre { get;set;}
        int Ataque { get;}
        int Defensa { get;}
        string GetTextToPrint();

    }
    
}