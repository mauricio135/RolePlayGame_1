using NUnit.Framework;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Se Valida que el Enano se cree y Comience con vida en 100.
        [Test]
        public void IniciaConVidaEnCien()
        {
            Enano pequeño = new Enano("Enano1", 2000);
            Assert.AreEqual(100, pequeño.Vida);

        }
        //Test que Valida el Funcionamiento de"GetTextToPrint()", deberia de devolver la cadena de la descripcion del Enano tal cual se la espera"
        [Test]
        public void ImprimeDatosDeEnanoCorrectamente()
        {
            Enano pequeño = new Enano("Enano1", 100);
            Elemento item1 = new Elemento("Capa", 200, 400);
            Elemento item2 = new Elemento("Espada", 200, 400);
            pequeño.AgregarElemento(item1);
            pequeño.AgregarElemento(item2);

            string esperado = "El Enano Enano1 tiene 100 puntos de Vida y los siguientes elementos:  'Capa'  'Espada'  ";
            string resulado = pequeño.GetTextToPrint();
            Assert.AreEqual(esperado, resulado);

        }
        //Test que Valida el Funcionamiento de"CurarEnano()", deberia de volver a su valor maximo de vida (100)"
        [Test]
        public void SiCuroEnanosVuelveLaVidaACien()
        {
            Enano pequeño = new Enano("Enano1", 100);
            pequeño.Vida = 3;
            pequeño.CurarEnano();
            Assert.AreEqual(100, pequeño.Vida);



        }
    }
}
