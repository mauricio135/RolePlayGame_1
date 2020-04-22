using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Mago
    {
        private static int _vidaInicial = 100;
        public static int VidaInicial
        {
            get { return _vidaInicial; }
            set { _vidaInicial = value; }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value;}
        }
        private int _vida;
        public int Vida
        {
            get { return _vida; }
            set { _vida = value; }
        }

        private ArrayList Ataques = new ArrayList();
        private ArrayList defensas = new ArrayList();
        private ArrayList elementos = new ArrayList();
        private ArrayList LibroDeHechizos = new ArrayList();

        //public void AgregarAtaque (Ataque ataque)
        //{
        //    this.ataques.Add(ataque);
        //}
        //public void QuitarAtaque (Ataque ataque)
        //{
        //    this.ataques.Remove(ataque);
        //}
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
            return this.Vida > 0;
        }


        public Mago (string name)
        {
            this.Nombre = name;
            this.Vida = Mago.VidaInicial;
        }

        public int CalcularAtaqueTotal ()
        {
            int total = 0;
            foreach (Elemento elemento in elementos)
            {
                total += elemento.Ataque;
            } 
            return total;
        }

        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (Elemento elemento in elementos)
            {
                total += elemento.Defensa;
            } 
            return total;
        }

        public string GetTextToPrint()
        {
            string todosloselementos = "";
            foreach (Elemento item in this.elementos)
            {
                todosloselementos += item.GetTextToPrint();
            }

            return ($"El Dementor {this.Nombre} tiene {this.Vida} de vida y los siguientes elementos: {todosloselementos} ");

        }

    }
}