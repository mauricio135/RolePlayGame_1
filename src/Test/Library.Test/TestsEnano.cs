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

        [Test]
        public void IniciaConVidaEnCien()
        {    
            Enano pequeño = new Enano("Enano1",2000);
            Assert.AreEqual(100,pequeño.Vida);
            
        }
         [Test]
        public void ImprimeDatosDeEnanoCorrectamente()
        {    
            Enano pequeño = new Enano("Enano1",100);
            Elemento item1 = new Elemento("Capa",200,400);
            Elemento item2 = new Elemento("Espada",200,400);
            pequeño.AgregarElemento(item1);
            pequeño.AgregarElemento(item2);

            string esperado = "El Enano Enano1 tiene 100 puntos de Vida y los siguientes elementos:  'Capa'  'Espada'  ";
            string resulado = pequeño.GetTextToPrint();
            Assert.AreEqual(esperado,resulado);
            
        }
    }
}
