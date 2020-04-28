using System;
using System.Collections.Generic;


namespace RolePlayGame_1.Library
{
    //Interfase Ipersonaje será el molde de todos los personajes que tendran estos métodos y atributos.
    public interface IPersonaje
    {
        int CalcularAtaqueTotal();
        int CalcularDefensaTotal();
        void Curar();
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
