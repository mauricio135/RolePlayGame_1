
using System;
using System.Collections;

namespace RolePlayGame_1.Library
{
    public class Elemento
    {
        private string _nombre;
        public string Nombre
        {
            get {return _nombre;}
            set {_nombre = value;}
        }
        private int _ataque;
        public int Ataque
        {
            get { return _ataque; }
            set { _ataque = value; }
        }
        private int _defensa;
        public int Defensa
        {
            get { return _defensa; }
            set { _defensa = value; }
        }

        public Elemento (string nombre, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
        
         public string GetTextToPrint()
        {

            return $" '{this._nombre}' ";   

        }


    }
    
}