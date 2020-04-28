using System;
using System.Collections;
using RolePlayGame_1.library;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creacion de Enanos
            //Creo a Enano Tommy y le asigno dos elementos diferentes
            IPersonaje enano1 = new Enano("Tommy");
            IElemento elemento1 = new Hacha("Hacha Milagrosa");
            enano1.Elementos.Add(elemento1);
            IElemento elemento2 = new Escudo("Escudo Durisimo");
            enano1.Elementos.Add(elemento2);

            //Creo a Enano Lucas y le asigno dos elementos diferentes
            IPersonaje enano2 = new Enano("Lucas");
            IElemento elemento3 = new Hacha("Hacha Loca");
            enano2.Elementos.Add(elemento3);
            IElemento elemento4 = new Escudo("Escudo Largo");
            enano2.Elementos.Add(elemento4);

            //Ataque entre Enanos -> Tommy Ataca a Lucas  
            enano1.RecibirAtaque(enano2);            
            PrintPersonaje(enano1);            
             //Ataque entre Enanos -> Lucas Ataca a Tommy   
            enano2.RecibirAtaque(enano1);            
            PrintPersonaje(enano2);
                
            //Curo Enanos: Tommy vuelve a tener 100 de vida
            enano1.Curar();
            PrintPersonaje(enano1);






            Elfo Dooby = new Elfo("Dooby");
            Elfo Belatrix = new Elfo("Belatrix");
            Elemento dagaBelatrix = new Elemento("Daga Belatrix", 101, 0);
            Elemento Calcetin = new Elemento("Calcetín", 0, 3);
            Dooby.AgregarElemento(Calcetin);
            Belatrix.AgregarElemento(dagaBelatrix);

            //Belatrix ataca a dobby
            Dooby.Vida = Dooby.Vida - Belatrix.CalcularAtaqueTotal();
            Console.WriteLine(Dooby.Nombre + "\t" + "Vivo:  " + Dooby.TieneVida());


            //Prueba instanciar magos
            Mago antioch = new Mago("Antioch Peverell");
            Elemento varitaSauco = new Elemento("Varita de Sauco", 100, 15);
            antioch.AgregarElemento(varitaSauco);

            Mago cadmus = new Mago("Cadmus Peverell");
            Elemento piedraResurreccion = new Elemento("Piedra de la Resurrección", 10, 5);
            cadmus.AgregarElemento(piedraResurreccion);

            Console.WriteLine($"Ataque total de {antioch.Nombre}: {antioch.CalcularAtaqueTotal()}");

            //Creo Dementores
            Dementor dementor1 = new Dementor("SeñorOscuro", 100);

            Elemento elementoDementor1 = new Elemento("Bostezo Fatal", 10, 50);
            Elementos.Add(elementoDementor1);
            dementor1.AgregarElemento(elementoDementor1);
            Elemento elementoDementor2 = new Elemento("Alas de murcielago", 2, 4);
            dementor1.AgregarElemento(elementoDementor2);

            Dementor dementor2 = new Dementor("Ron", 100);

            Elemento elementoDementor3 = new Elemento("Traje invisible", 1, 1);
            dementor2.AgregarElemento(elementoDementor3);
            Elemento elementoDementor4 = new Elemento("Gorro Asesino", 5, 6);
            dementor2.AgregarElemento(elementoDementor4);

            //Agrego Ataques a los Dementores
            Ataque ataqueDementor1 = new Ataque("Absorve energia", 2);
            Ataque ataqueDementor2 = new Ataque("Bostezo venenoso", 4);

            dementor1.AgregarAtaque(ataqueDementor1);
            dementor2.AgregarAtaque(ataqueDementor2);



            //Ataque entre Dementores                            
            dementor1.vida = dementor1.vida - dementor2.CalcularAtaqueTotal() - dementor1.CalcularDefensaTotal();
            PrintDementor.ConsolePrintDementor(dementor1);


            //Curo Dementor
            dementor1.CurarDementor();
            PrintDementor.ConsolePrintDementor(dementor1);

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

