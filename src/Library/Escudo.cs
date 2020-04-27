namespace RolePlayGame_1.Library
{
{
    public class Escudo : IElemento
    {
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ({this.Ataque}/{this.Defensa}) ";

        }

    }
}
}