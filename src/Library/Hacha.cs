namespace RolePlayGame_1.Library
{

    public class Hacha : IElemento
    {
        public string Nombre { get;set; }
        public int Ataque { get; } = 10;
        public int Defensa { get; } = 1;

        public Hacha(string nombre)
        {
            this.Nombre = nombre;
         
        }
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ({this.Ataque}/{this.Defensa})";

        }

    }
}
