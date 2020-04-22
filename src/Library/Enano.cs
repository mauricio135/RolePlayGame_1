
using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Enano
    {

        private string nombre { get; set; }
        private int vida { get; set; }
        private static int vidainicial { get; set; } = 100;
        private ArrayList ataques = new ArrayList();
        private ArrayList defensas = new ArrayList();
        private ArrayList elementos = new ArrayList();

        public Enano(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = Enano.vidainicial;

        }
        public string Nombre { get; set; }
        public int Vida { get; set; }

        public void AgregarAtaque(Ataque ataque)
        {
            this.ataques.Add(ataque);
        }
        public void QuitarAtaque(Ataque ataque)
        {
            this.ataques.Remove(ataque);
        }
        public void AgregarDefensa(Defensa defensa)
        {
            this.defensas.Add(defensa);
        }
        public void QuitarDefensa(Defensa defensa)
        {
            this.defensas.Remove(defensa);
        }
        public void AgregarElemento(Elemento elemento)
        {
            this.elementos.Add(elemento);
        }
        public void QuitarElemento(Elemento elemento)
        {
            this.elementos.Remove(elemento);
        }

        public bool TieneVida()
        {
            return this.vida > 0;
        }
        public string GetTextToPrint()
        {
            string todoslosataques = "";
            foreach (Ataque item in this.ataques)
            {
                todoslosataques = ataques + item.Nombre;
            }

            return ($"El Enano {this.Nombre} tiene {this.Vida} puntos de Vida y ");

        }


    }
}