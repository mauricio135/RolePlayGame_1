using System;
using System.Collections;
using System.Collections.Generic;

namespace RolePlayGame_1.Library
{
    public class Mago: IPersonaje
    {
        public static int VidaInicial { get; } = 100;
        public string Nombre { get; set; }
        public int Vida { get; set; }

        public static int Ataque { get; } = 10;
        public static int Defensa { get; } = 5;
        
        private List <IElementoMagico> Elementos = new List<IElementoMagico>();
        private List <IHechizo> LibroDeHechizos = new List <IHechizo>();

        public void AgregarElemento (IElemento elemento)
        {
            this.Elementos.Add(elemento);
        } 
        public void QuitarElemento (Elemento elemento)
        {
            this.Elementos.Remove(elemento);
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
            foreach (IElemento elemento in elementos)
            {
                total += elemento.Ataque;
            } 
            return total;
        }

        //Aplicamos Expert para calcular la Defensa Total
        //La clase mago tiene todos los datos para calcular

        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (IElemento elemento in Elementos)
            {
                total += elemento.Defensa;
            } 
            return total;
        }

        //Cada clase de IPersonaje tiene su método propio de GetTextToPrint
        //Aplicamos polimorfismo

        public string GetTextToPrint()
        {
            string todosloselementos = "";
            foreach (IElemento item in this.Elementos)
            {
                todosloselementos += item.GetTextToPrint(); 
            }

            return ($"El Mago {this.Nombre} tiene {this.Vida} de vida y los siguientes elementos: {todosloselementos} ");

        }

        public void Curar()
        {
            this.Vida = VidaInicial;
        }

        //El método recibirAtaque se localiza en la clase que recibe el ataque porque tiene 
        //los valores necesarios para calcular el daño recibido y efectuar el cambio
        //de vida (recibe el ataque por parámetro)
        public void RecibirAtaque (IPersonaje enemy)
        {
            int attack = enemy.CalcularAtaqueTotal - this.CalcularDefensaTotal;
            int damage = attack > 0 ? attack : 0;
            this.Vida -= damage;
        }

    }
}