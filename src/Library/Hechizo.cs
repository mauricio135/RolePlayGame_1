using System;
using System.Collections;

namespace RolePlayGame_1.Library
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