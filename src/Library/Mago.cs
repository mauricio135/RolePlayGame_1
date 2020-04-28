using System;
using System.Collections;
using System.Collections.Generic;

namespace RolePlayGame_1.Library
{

/*
Mago implementa IPersonaje que es el molde para todos los personajes. 
Usamos polimorfismo ya que si bien la interfaz es el molde, cada personaje implementa en su clase los métodos de una forma particular. Acorde a las necesidades.
*/
    public class Mago: IPersonaje
    {
        public int VidaInicial { get; } = 100;
        public string Nombre { get; set; }
        public int Vida { get; set; }

        public int Ataque { get; } = 10;
        public int Defensa { get; } = 5;
        
        public List <IElemento> Elementos{get;set;} = new List<IElemento>();
        public List <IHechizo> LibroDeHechizos{get;set;} = new List <IHechizo>();

        public void AgregarElemento (IElemento elemento)
        {
            this.Elementos.Add(elemento);
        } 
        public void QuitarElemento (IElemento elemento)
        {
            this.Elementos.Remove(elemento);
        }

        public void AgregarHechizo (IHechizo hechizo)
        {
            this.LibroDeHechizos.Add(hechizo);
        }
        public void QuitarHechizo (IHechizo hechizo)
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
            this.Vida = this.VidaInicial;
        }

        public int CalcularAtaqueTotal ()
        {
            int total = 0;
            foreach (IElemento elemento in Elementos)
            {
                total += elemento.Ataque;
            } 
            return total;
        }

/*
Modificamos la forma de calcular Defensa y Ataque acorde a los comentarios de la entrega anterior, quitamos las clases Ataque y Defensa.
Se simplifica el código, ahora son atributos y se calcula ataque total  y defensa total. 
Aplicamos Patrón Experto, ya que la clase es la responsable de calcular ataque y defensa total y posee todos los datos para hacerlo
*/

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

/* Agregamos el metodo RecibirAtaque para restar el daño, teniendo en cuenta la defensa y calcular la vida del personaje. Esto fue posible gracias a la interfaz IPersonaje.
Usamos nuevamente polimorfismo.
*/
        public void RecibirAtaque (IPersonaje enemy)
        {
            int attack = enemy.CalcularAtaqueTotal() - this.CalcularDefensaTotal();
            int damage = attack > 0 ? attack : 0;
            this.Vida -= damage;
        }

    }
}