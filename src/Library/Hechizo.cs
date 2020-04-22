using System;

namespace RolePlayGame_1
{
    public class Hechizo
    {
        private string Nombre { get; set; }
        private int Danio { get; set; }

        public Hechizo (string nombre, int danio)
        {
            this.Nombre = nombre;
            this.Danio = danio;
        }
    }
    
}