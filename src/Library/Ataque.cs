namespace RolePlayGame_1
{
    public class Ataque
    {
        public string Nombre { get; set; }
        public int Danio { get; set; }

        public Ataque(string nombre, int danio)
        {
            this.Nombre = nombre;
            this.Danio = danio;
        }
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ";

        }



    }

}