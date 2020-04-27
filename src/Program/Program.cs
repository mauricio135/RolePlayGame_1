using System;
using System.Collections;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{
    public class Program
    {
        private static ArrayList Elementos = new ArrayList();
        static void Main(string[] args)
        {
            //Creacion de Enanos
            Enano enano1 = new Enano("Tommy", 100);

            Elemento elemento1 = new Elemento("Capa", 10, 50);
            Elementos.Add(elemento1);
            enano1.AgregarElemento(elemento1);
            Elemento elemento2 = new Elemento("Espada", 2, 4);
            enano1.AgregarElemento(elemento2);

            Enano enano2 = new Enano("Lucas", 100);

            Elemento elemento3 = new Elemento("Armadura", 1, 1);
            enano2.AgregarElemento(elemento3);
            Elemento elemento4 = new Elemento("Posion Magica", 5, 6);
            enano2.AgregarElemento(elemento4);
            
            //Agrego Ataques a los Enanos
            Ataque ataque1= new Ataque("Patada Voladora",2);
            Ataque ataque2= new Ataque("Salto Violento",4);

            enano1.AgregarAtaque(ataque1);
            enano2.AgregarAtaque(ataque2);



            //Ataque entre Enanos Tommy Ataca a Lucas                            
            enano1.Vida = enano1.Vida - enano2.CalcularAtaqueTotal() - enano1.CalcularDefensaTotal();
            PrintEnano.ConsolePrintEnano(enano1);

            //Ataque entre Enanos Lucas Ataca a Tommy                            
            enano2.Vida = enano2.Vida - enano1.CalcularAtaqueTotal() - enano2.CalcularDefensaTotal();
            PrintEnano.ConsolePrintEnano(enano2);
            
            //Curo Enanos:  Tommy
            enano1.CurarEnano();
            PrintEnano.ConsolePrintEnano(enano1);






           Elfo Dooby= new Elfo("Dooby");
           Elfo Belatrix=new Elfo("Belatrix");
           Elemento dagaBelatrix=new Elemento("Daga Belatrix",101,0);
           Elemento Calcetin=new Elemento("Calcetín",0,3);
           Dooby.AgregarElemento(Calcetin);
           Belatrix.AgregarElemento(dagaBelatrix);

           //Belatrix ataca a dobby
           Dooby.Vida=Dooby.Vida-Belatrix.CalcularAtaqueTotal();
           Console.WriteLine(Dooby.Nombre+  "\t" + "Vivo:  "+ Dooby.TieneVida());


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