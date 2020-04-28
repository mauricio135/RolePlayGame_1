using System;
using System.Collections;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{

/* Aplicamos en nuestro código, SRP, Expert y Polimorfismo.
Realizamos todas las correcciones sugeridas por la cátedra
*/
    public class Program
    {
        static void Main(string[] args)
        {
            //Creacion de Enanos
            //Creo a Enano Tommy y le asigno dos elementos diferentes
            IPersonaje enano1 = new Enano("Tommy");
            IElemento elemento1 = new Hacha("Hacha Milagrosa");
            enano1.AgregarElemento(elemento1);
            IElemento elemento2 = new Escudo("Escudo Durisimo");
            enano1.AgregarElemento(elemento2);

            //Creo a Enano Lucas y le asigno dos elementos diferentes
            IPersonaje enano2 = new Enano("Lucas");
            IElemento elemento3 = new Hacha("Hacha Loca");
            enano2.AgregarElemento(elemento3);
            IElemento elemento4 = new Escudo("Escudo Largo");
            enano2.AgregarElemento(elemento4);

            //Ataque entre Enanos -> Tommy Ataca a Lucas  
            enano1.RecibirAtaque(enano2);            
            PrintPersonaje print =new PrintPersonaje();            
             //Ataque entre Enanos -> Lucas Ataca a Tommy   
            enano2.RecibirAtaque(enano1);            
            print.ConsolePrint(enano2);
                
            //Curo Enanos: Tommy vuelve a tener 100 de vida
            enano1.Curar();
            print.ConsolePrint(enano1);
            //los Enanos se crean
            Elfo dooby = new Elfo("Dooby");
            Elfo belatrix = new Elfo("Belatrix");
            IElemento dagaBelatrix = new Espada("Daga Belatrix");
            IElemento calcetin = new Armadura("Calcetín");
            dooby.AgregarElemento(calcetin);
            belatrix.AgregarElemento(dagaBelatrix);

            //Belatrix ataca a dobby
            dooby.Vida = dooby.Vida - belatrix.CalcularAtaqueTotal();
            Console.WriteLine(dooby.Nombre + "\t" + "Vivo:  " + dooby.TieneVida());

            //Creo Dementores
            Dementor dementor1 = new Dementor("SeñorOscuro");

            IElemento elementoDementor1 = new Daga("Bostezo Fatal");
            dementor1.AgregarElemento(elementoDementor1);
            IElemento elementoDementor2 = new Capa("Alas de murcielago");
            dementor1.AgregarElemento(elementoDementor2);

            Dementor dementor2 = new Dementor("Ron");

            IElemento elementoDementor3 = new Capa("Traje invisible");
            dementor2.AgregarElemento(elementoDementor3);
            IElemento elementoDementor4 = new Daga("Gorro Asesino");
            dementor2.AgregarElemento(elementoDementor4);

    

            //Ataque entre Dementores                            
            dementor1.RecibirAtaque(dementor2) ;
            print.ConsolePrint(dementor1);


            //Curo Dementor
            dementor1.Curar();
            print.ConsolePrint(dementor1);

           //Prueba instanciar magos
           Mago antioch = new Mago ("Antioch Peverell");
           Varita sauco = new Varita ("Varita de Sauco");
           antioch.AgregarElemento(sauco);
           
           Mago cadmus = new Mago ("Cadmus Peverell");
           Sombrero seleccionador = new Sombrero ("Sombrero seleccionador");
           cadmus.AgregarElemento(seleccionador);
        
        }
    }
}

