using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Mago
    {
        private static int VidaInicial { get; set; } = 100;
        private string nombre { get; set; }
        private int vida { get; set; }
        private ArrayList ataques = new ArrayList();
        private ArrayList defensas = new ArrayList();
        private ArrayList elementos = new ArrayList();
        private ArrayList LibroDeHechizos = new ArrayList();

        public void AgregarAtaque (Ataque ataque)
        {
            this.ataques.Add(ataque);
        }
        public void QuitarAtaque (Ataque ataque)
        {
            this.ataques.Remove(ataque);
        }
        public void AgregarDefensa (Defensa defensa)
        {
            this.defensas.Add(defensa);
        }
        public void QuitarDefensa (Defensa defensa)
        {
            this.defensas.Remove(defensa);
        }
        public void AgregarElemento (Elemento elemento)
        {
            this.elementos.Add(elemento);
        }
        public void QuitarElemento (Elemento elemento)
        {
            this.elementos.Remove(elemento);
        }

        public void AgregarHechizo (Hechizo hechizo)
        {
            this.LibroDeHechizos.Add(hechizo);
        }
        public void QuitarHechizo (Hechizo hechizo)
        {
            this.LibroDeHechizos.Remove(hechizo);
        }
        public bool Tienevida()
        {
            return this.vida > 0;
        }


        public Mago (string name)
        {
            this.nombre = name;
            this.vida = Mago.VidaInicial;
        }

        public int CalcularAtaqueTotal ()
        {
            int total = 0;
            foreach (Ataque ataque in ataques)
            {
                total += ataque.Danio;
            } 
            return total;
        }

        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (Defensa defensa in defensas)
            {
                total += defensa.Proteccion;
            } 
            return total;
        }

    }
}