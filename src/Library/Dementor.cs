using System;
using System.Collections;
using RolePlayGame_1;
using RolePlayGame_1.Library;


namespace RolePlayGame_1
{
    public class Dementor
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


        public void CurarDementor()
        {
            this.vida = 100;
        }

        public string GetTextToPrint()
        {
            string todosloselementos = "";
            foreach (Elemento item in this.elementos)
            {
                todosloselementos += item.GetTextToPrint();
            }

            return ($"El Dementor {this.nombre} tiene {this.vida} de vida y los siguientes elementos: {todosloselementos} ");

        }
        

    }
}