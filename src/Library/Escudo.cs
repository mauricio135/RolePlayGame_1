namespace RolePlayGame_1.Library
{

    public class Escudo : IElemento
    {
        public string Nombre { get;set; }
        public int Ataque { get; } = 0;
        public int Defensa { get; } = 10;

        public Escudo(string nombre)
        {
            this.Nombre = nombre;
         
        }
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ({this.Ataque}/{this.Defensa})";

        }

    }
}
