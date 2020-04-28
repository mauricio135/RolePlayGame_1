using System;
using System.Collections.Generic;


namespace RolePlayGame_1.Library
{
    /*
    Interfaz Ipersonaje será el molde de todos los personajes que tendran estos métodos y atributos.
    Aplicando luego polimorfismo en cada clase de cada personaje.
    */
    
    public interface IPersonaje
    {
        int CalcularAtaqueTotal();
        int CalcularDefensaTotal();
        void Curar();        
        bool TieneVida();
        void RecibirAtaque(IPersonaje personaje);
        void AgregarElemento(IElemento elemento);        
        String GetTextToPrint();

        String Nombre {get; set;}
        int VidaInicial {get;}
        int Vida {get; set;}
        int Ataque {get;}
        int Defensa {get;}
                
        List <IElemento> Elementos  {get; set;}


    }
}
