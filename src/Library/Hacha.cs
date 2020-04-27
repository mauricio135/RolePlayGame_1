namespace RolePlayGame_1.Library
{

    public class Hacha : IElemento
    {
        public string Nombre { get; }
        public int Ataque { get; }
        public int Defensa { get; }
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
