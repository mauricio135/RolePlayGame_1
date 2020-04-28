using System;
using System.Collections;
using System.Collections.Generic;

namespace RolePlayGame_1.Library
{
    public class Elfo : IPersonaje
    {
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = VidaInicial;

        }
        public string Nombre { get; set; }
        public int Vida { get; set;}
        public int Ataque { get; }
        public int Defensa { get; }
        public int VidaInicial { get; } = 100;
        public List<IElemento> Elementos { get; set; }
        
        public void AgregarElemento (IElemento elemento)
        {
            this.Elementos.Add(elemento);
        }
        public void QuitarElemento (IElemento elemento)
        {
            this.Elementos.Remove(elemento);
        }
        public bool TieneVida ()
        {
            return this.Vida >0 ;
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
        public int CalcularDefensaTotal ()
        {
            int total = 0;
            foreach (IElemento elemento in Elementos)
            {
                total += elemento.Defensa;
            } 
            return total;
        }
        public void RecibirAtaque (IPersonaje enemy)
        {
            int attack = enemy.CalcularAtaqueTotal() - this.CalcularDefensaTotal();
            int damage = attack > 0 ? attack : 0;
            this.Vida -= damage;
        }

    }
}