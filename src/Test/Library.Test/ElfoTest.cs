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

        {   Elfo Legolas=new Elfo("Legolas");  
            Legolas.Vida-=35;
            Assert.AreEqual(65,Legolas.Vida) ;
            
        }
        [Test]
        public void DefensaTotalCorrecta()
        {
            Elfo Dobby =new Elfo("Dobby");
            Elemento item1 = new Elemento("calsetín",10,0);
            Elemento item2 = new Elemento ("Daga de Belatrix",0,50);
            Dobby.AgregarElemento(item1);
            Dobby.AgregarElemento(item2);

            Assert.AreEqual(50,Dobby.CalcularDefensaTotal());
        
        }
        [Test]
        public void CalculoDeSumaDeAtaque()
        {
            Elfo elfo = new Elfo("elfo");
            Elemento item1= new Elemento("cerveza",10,-3);
            Elemento item2 = new Elemento ("daga",20,0);
            elfo.AgregarElemento(item1);
            elfo.AgregarElemento(item2);
            Assert.AreEqual(30,elfo.CalcularAtaqueTotal());
        }
    }
}
