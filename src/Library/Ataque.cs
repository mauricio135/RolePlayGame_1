namespace RolePlayGame_1
{
    public class Ataque
    {
        public string Nombre { get; set; }
        public int Intensidad { get; set; }

        public Ataque (string nombre, int intensidad)
        {
            this.Nombre = nombre;
            this.Intensidad = intensidad;
        }
    }


}