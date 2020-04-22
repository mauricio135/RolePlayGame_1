using System;

namespace Program
{
    public class Elfo
    {
        private string nombre{get;set;}
        
        private int vida{get;set;}
        private Ataque ataques{get;set;}

        private int danio{get;set;}
        private Defensa defensa{get;set;}
        private Elemento elementos{get;set;}

        public Elfo(string Nombre,int Vida,int danio,ataque ataque,defensa Defensa)
        {
            this.nombre=Nombre;
            this.vida=Vida;
            this.danio=danio;
            this.ataques=ataques;
            this.defensa=Defensa;

        }
            public void ataque(Elfo OtroPersonaje)
        {
            OtroPersonaje.vida=OtroPersonaje.vida-this.danio;
        }
            public bool TieneVida ()
        {
            return this.vida >0 ;
        } 
    } 
}