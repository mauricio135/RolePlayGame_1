namespace RolePlayGame_1.Library
{

    public class Hacha : IElemento
    {
        public string Nombre { get;set; }
        public int Ataque { get;set; }
        public int Defensa { get;set; }
        public Hacha(string nombre, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ({this.Ataque}/{this.Defensa})";

        }

    }
}
