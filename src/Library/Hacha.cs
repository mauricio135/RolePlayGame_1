namespace RolePlayGame_1.Library
{

    public class Hacha : IElemento
    {
/* Hacha implementa la interfaz IElemento, ya que esta es el molde para todos los elementos. 
Cada elemento se imprime en una operación polimórfica como cada elemento se deba imprimir.
Se aplica la sugerencia de la calificacion anterior de Eduardo para setear valores a los distintos elementos.
*/
        public string Nombre { get;set; }
        public int Ataque { get; } = 10;
        public int Defensa { get; } = 1;

        public Hacha(string nombre)
        {
            this.Nombre = nombre;
         
        }
/*
Aplicamos SRP, los Elementos tienen una única responsabilidad
y la clase tiene una unica razon para cambiar. En este caso la forma de imprimirse
*/ 
        public string GetTextToPrint()
        {

            return $" '{this.Nombre}' ({this.Ataque}/{this.Defensa})";

        }

    }
}
