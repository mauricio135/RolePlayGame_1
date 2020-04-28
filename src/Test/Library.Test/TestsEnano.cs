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
            IPersonaje pequeño = new Enano("Enano1");
            Assert.AreEqual(100, pequeño.Vida);
        }
    }
}
