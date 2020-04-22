using NUnit.Framework;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class MagoTests
    {
        [Test]
        public void DescuentaVidaCorrectamente()
        {
            Mago merlin = new Mago ("Merlin");
            
            merlin.Vida -= 15;

            Assert.AreEqual(85, merlin.Vida);
        }

        [Test]
        public void AtaqueTotalCorrecto()
        {
            Mago merlin = new Mago ("Merlin");
            Elemento item1 = new Elemento ("Dummy", 10, 0);
            Elemento item2 = new Elemento ("Dummy2", 2, 1);
            Elemento item3 = new Elemento ("Dummy3", 0, 14);
            merlin.AgregarElemento(item1);
            merlin.AgregarElemento(item2);
            merlin.AgregarElemento(item3);

            Assert.AreEqual(12, merlin.CalcularAtaqueTotal());
        }

        [Test]
        public void DefensaTotalCorrecto()
        {
            Mago merlin = new Mago ("Merlin");
            Elemento item1 = new Elemento ("Dummy", 10, 0);
            Elemento item2 = new Elemento ("Dummy2", 2, 1);
            Elemento item3 = new Elemento ("Dummy3", 0, 14);
            merlin.AgregarElemento(item1);
            merlin.AgregarElemento(item2);
            merlin.AgregarElemento(item3);

            Assert.AreEqual(15, merlin.CalcularDefensaTotal());
        }
    }
}