using System;
using System.Collections;
using RolePlayGame_1;
namespace RolePlayGame_1.Library
{
    public class Elfo
    {
        private string _nombre;
        public string Nombre
        {
            get{return _nombre;}
            set{_nombre = value;}

        }
        
        private int _vida;
        public int Vida
        {
            get{return _vida;}
            set {_vida = value;}
        }
        private static int _vidaInicial=100;
        public static int VidaInicial
        {
            get {return _vidaInicial;}
            set {_vidaInicial = value;}
        }
      private ArrayList Ataques = new ArrayList();
      private ArrayList Defensas = new ArrayList();
      private ArrayList Elementos = new ArrayList(); 

       
       // public void AgregarAtaque(Ataque ataque)
       // {
       //     this.Ataques.add(ataque);
     //       int danio=ataque.danio;
     //   }
     //   public void QuitarAtaque(Ataque ataque)
     //   {   
     //           this.ataque.Remove(ataque);
     //   }
        public void AgregarDefensa (Defensa defensa)
        {
            this.Defensas.Add(defensa);
        }
        public void QuitarDefensa (Defensa defensa)
        {
            this.Defensas.Remove(defensa);
        }
        public void AgregarElemento (Elemento elemento)
        {
            this.Elementos.Add(elemento);
        }
        public void QuitarElemento (Elemento elemento)
        {
            this.Elementos.Remove(elemento);
        
        }
        public bool TieneVida ()
        {
            return this.Vida >0 ;
        } 
        public Elfo(string name)
        {
        this.Nombre=name;
        this.Vida=Elfo.VidaInicial;
        }
        public int CalcularAtaqueTotal ()
        {
            int total = 0;
            foreach (Elemento elemento in Elementos)
            {
               total += elemento.Ataque;
            } 
           return total;
        }

        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (Elemento elemento in Elementos)
            {
                total += elemento.Defensa;
            } 
            return total;
        }
        public void CurarElfo()
        {
            this.Vida = 100;
        }

        public string GetTextToPrint()
        {
            string todosloselementos = "";
            foreach (Elemento item in this.Elementos)
            {
                todosloselementos += item.Nombre;
            }

            return ($"El Elfo {this.Nombre} tiene {this.Vida} de vida y los siguientes elementos: {todosloselementos} ");
        }

    }
}