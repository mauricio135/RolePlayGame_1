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
            PopulateElementos();
            foreach (Enano enano in Enanos)
            {
                Elemento prueba = new Elemento("Prueba de Elemento", 100, 200);
                enano.AgregarElemento(prueba);
                Elemento prueba2 = new Elemento("Prueba de Elemento2", 100, 300);
                enano.AgregarElemento(prueba2);

                PrintEnano.ImprimeEnano(enano);

            }



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
