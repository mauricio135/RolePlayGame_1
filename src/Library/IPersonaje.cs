using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    //Interfase Ipersonaje será el molde de todos los personajes que tendran estos métodos y atributos.
    public interface IPersonaje
    {
        int CalcularAtaque();
        int CalcularDefensaTotal();
        void Curar();
        void RecibirAtaque(IPersonaje personaje);
        String GetTextToPrint();

        String Nombre {get; set;}
        int VidaInicial {get; set;}
        int Vida {get; set;}
        int Ataque {get; set;}
        int Defensa {get; set;}
        
        List <IElemento> Elementos  {get; set;}


    }
}
