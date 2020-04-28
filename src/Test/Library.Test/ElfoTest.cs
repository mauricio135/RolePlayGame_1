using NUnit.Framework;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class ElfoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculoDeDañoCorrecto()

        {   IPersonaje Legolas=new Elfo("Legolas");  
            Legolas.Vida-=35;
            Assert.AreEqual(65,Legolas.Vida) ;
            
        }
    }
}
