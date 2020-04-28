using System;
using System.Collections;

namespace RolePlayGame_1.Library
{

/* Interfaz que sera el molde de todos los hechizos que es una propiedad (la de tener hechizos) que le compete solo a los magos, 
sus atributos comunes y el metodo donde se imprimen que luego cada Mago implementará en su clase.
Aplicando Polimorfismo
*/
    public interface IHechizo
    {
        string Nombre { get; }
        string GetTextToPrint();
        
    }
    
}