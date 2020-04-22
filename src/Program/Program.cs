using System;
using System.Collections;
using RolePlayGame_1.Library;

namespace RolePlayGame_1
{
    public class Program
    {
        private static ArrayList Elementos = new ArrayList();
        private static ArrayList Enanos = new ArrayList();
        static void Main(string[] args)
        {
            //   PopulateElementos();

            //    foreach (Enano enano in Enanos)
        
                Enano enano1 = new Enano("Tommy", 100);

                Elemento elemento1 = new Elemento("Capa", 10, 50);
                enano1.AgregarElemento(elemento1);
                Elemento elemento2 = new Elemento("Espada", 2, 4);
                enano1.AgregarElemento(elemento2);  
 

                Enano enano2 = new Enano("Lucas", 100);

                Elemento elemento3 = new Elemento("Armadura", 1, 1);
                enano2.AgregarElemento(elemento3);
                Elemento elemento4 = new Elemento("Posion Magica", 5, 6);
                enano2.AgregarElemento(elemento4);  

                //Ataque entre Enanos Tommy Ataca a Lucas                            
                enano1.Vida = enano1.Vida - enano2.CalcularAtaqueTotal() - enano1.CalcularDefensaTotal();                
                PrintEnano.ConsolePrintEnano(enano1);

                //Ataque entre Enanos Lucas Ataca a Tommy                            
                enano2.Vida = enano2.Vida - enano1.CalcularAtaqueTotal() - enano2.CalcularDefensaTotal();                
                PrintEnano.ConsolePrintEnano(enano2);





            static void PopulateElementos()
            {
                AddElementos("Hacha", 100, 0);
                AddElementos("Martillo", 200, 0);
                AddElementos("Escudo", 0, 400);
                AddEnanos("Enano1", 300, 89);
                AddEnanos("Enano2", 300, 89);


            }


            static void AddEnanos(string nombre, int ataque, int defensa)
            {
                Enanos.Add(new Enano(nombre, ataque));
            }

            static void AddElementos(string nombre, int ataque, int defensa)
            {
                Elementos.Add(new Elemento(nombre, ataque, defensa));
            }



        }
    }
}
