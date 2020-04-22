using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Defensa
    {
        public string Nombre { get; set; }
        private int Proteccion;

        public int getProteccion ()
        {
            return this.Proteccion;
        }

        public Defensa (string nombre, int proteccion)
        {
            this.Nombre = nombre;
            this.Proteccion = proteccion;
        }
    }
}