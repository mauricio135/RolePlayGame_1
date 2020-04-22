using System;
using System.Collections;

namespace Program
{
    class Dementor
    {

        private string nombre {get;set;}
        private int vida {get;set;}
        private static int VidaInicial { get; set; } = 100;
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

        public Dementor (string Nombre, int Vida)
            {
                this.nombre = Nombre;
                this.vida = Dementor.VidaInicial;
                
            }

        public bool Tienevida ()
            {
                return this.vida > 0;
            }

    }