using NUnit.Framework;
using RolePlayGame_1;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class TestsDementor
    {
        [SetUp]
        public void Setup()
        {
        }
        //Se Valida que el Enano se cree y Comience con vida en 100.
        [Test]
        public void IniciaVidaEnCien()
        {
            Dementor Hagrid = new Dementor("Dementor1", 200);
            Assert.AreEqual(100, Hagrid.vida);

        }
        
        //Test que Valida el Funcionamiento de"CurarDementor()", deberia de volver a su valor maximo de vida (100)"
        [Test]
        public void SiCuroEnanosVuelveLaVidaACien()
        {
            Dementor hermaione = new Dementor("hermaione", 100);
            hermaione.vida = 4;
            hermaione.CurarDementor();
            Assert.AreEqual(100, hermaione.vida);



        }

         [Test]
        public void CalculaDefensaCorrecto()
        {
            Dementor dumbuldore = new Dementor ("Dumbuldore", 100);
            Elemento item1 = new Elemento ("hacha", 10, 0);
            Elemento item2 = new Elemento ("espada", 2, 2);
            Elemento item3 = new Elemento ("latigo", 0, 11);
            dumbuldore.AgregarElemento(item1);
            dumbuldore.AgregarElemento(item2);
            dumbuldore.AgregarElemento(item3);

            Assert.AreEqual(13, dumbuldore.CalcularDefensaTotal());
        }
    }
}
