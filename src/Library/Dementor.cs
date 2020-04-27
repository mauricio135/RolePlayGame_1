using System;
using System.Collections;
using RolePlayGame_1;
using RolePlayGame_1.Library;


namespace RolePlayGame_1
{

    public class Dementor: IPersonaje
    {
        public static int VidaInicial { get; } = 100;
        public string Nombre { get; set; }
        public int Vida { get; set; }

        public static int Ataque { get; } = 15;
        public static int Defensa { get; } = 7;
        
        private List <IElemento> Elementos = new List<IElemento>();
       
        public void AgregarElemento (IElemento elemento)
        {
            this.Elementos.Add(elemento);
        } 
        public void QuitarElemento (Elemento elemento)
        {
            this.Elementos.Remove(elemento);
        }

        public bool Tienevida()
        {
            return this.Vida > 0;
        }


        public Dementor (string name)
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

        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (IElemento elemento in elementos)
            {
                total += elemento.Defensa;
            } 
            return total;
        }

        public string GetTextToPrint()
        {
            string todosloselementos = "";
            foreach (IElemento item in this.elementos)
            {
                todosloselementos += item.GetTextToPrint(); 
            }

            return ($"El Dementor {this.Nombre} tiene {this.Vida} de vida y los siguientes elementos: {todosloselementos} ");

        }

        public void Curar()
        {
            this.Vida = VidaInicial;
        }

        public void RecibirAtaque (IPersonaje enemy)
        {
            int attack = enemy.CalcularAtaqueTotal - this.CalcularDefensaTotal;
            int damage = attack > 0 ? attack : 0;
            this.Vida -= damage;
        }

    }
}

