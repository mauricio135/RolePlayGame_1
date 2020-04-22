using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Hechizo
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private int _danio;
        public int Danio
        {
            get { return _danio; }
            set { _danio = value; }
        }

        public Hechizo (string nombre, int danio)
        {
            this.Nombre = nombre;
            this.Danio = danio;
        }
    }
    
}