using System;

namespace RolePlayGame_1
{
    public class Elemento
    {
        private string Nombre { get; set;}
        private int Ataque { get; set; }
        private int Defensa { get; set; }
        private string Descripcion { get; set; }
        public Elemento (string nombre, int ataque, int defensa, string descripcion)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Descripcion = descripcion;
        }


    }
    
}