
using System;
using System.Collections;
using System.Collections.Generic;

namespace RolePlayGame_1.Library
{
    public class Enano : IPersonaje
    {
        private ArrayList ataques = new ArrayList();
        private ArrayList defensas = new ArrayList();
        private ArrayList elementos = new ArrayList();

        public Enano(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = VidaInicial;

        }
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int VidaInicial { get; } = 100;
        public List<IElemento> Elementos { get; set; }

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
        public void AgregarElemento(IElemento elemento)
        {
            this.elementos.Add(elemento);
        }
        public void QuitarElemento(IElemento elemento)
        {
            this.elementos.Remove(elemento);
        }

        //Este Metodo simplemente indica si el Enano esta vivo o no.
        public bool TieneVida()
        {
            return this.Vida > 0;
        }

        //Este Metodo Calcula el valor total de Ataque en base a los valores de sus Elementos.
        public int CalcularAtaqueTotal()
        {
            int total = 0;
            foreach (IElemento elemento in elementos)
            {
                total += elemento.Ataque;
            }
            return total;
        }
        //Este Metodo Calcula el valor total de Defensa  en base a los valores de sus Elementos.
        public int CalcularDefensaTotal()
        {
            int total = 0;
            foreach (IElemento elemento in elementos)
            {
                total += elemento.Defensa;
            }
            return total;
        }
        //Este Metodo hace que este personaje vuelva a tener el valor inicial de Vida
        public void Curar()
        {
            this.Vida = VidaInicial;
        }
       public void RecibirAtaque (IPersonaje enemy)
        {
            int attack = enemy.CalcularAtaqueTotal() - this.CalcularDefensaTotal();
            int damage = attack > 0 ? attack : 0;
            this.Vida -= damage;
        }
        //Metodo para extraer los valores del Objeto que deseo Imprimir con PrintEnano.cs
        public string GetTextToPrint()
        {
            string todosloselementos = "";
            string todoslosataques = "";
            foreach (IElemento item in this.elementos)
            {
                todosloselementos += item.GetTextToPrint();
            }
            foreach (Ataque ataque in this.ataques)
            {

                todoslosataques += ataque.Nombre;

            }

            return ($"El Enano {this.Nombre} tiene {this.Vida} puntos de Vida y los siguientes elementos: {todosloselementos} y los siguientes Ataques = {todoslosataques}");

        }


    }
}