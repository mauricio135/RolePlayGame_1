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
        public void Test2()
        {    
            Enano pequeño = new Enano("Enano1",2000);
            Assert.AreEqual(100,pequeño.Vida);


            
        }
    }
}
