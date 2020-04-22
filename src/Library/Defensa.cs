using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Defensa
    {
        private string Nombre { get; set; }
        private int Proteccion { get; set; }

        public Defensa (string nombre, int proteccion)
        {
            this.Nombre = nombre;
            this.Proteccion = proteccion;
        }
    }
}