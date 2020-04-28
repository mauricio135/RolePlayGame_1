using NUnit.Framework;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class MagoTests
    {
        private Mago merlin = new Mago ("Merlin");
        private IElemento vara = new Varita ("Dummy");
        private IElemento sombrero = new Sombrero ("Dummy2"); 


        [Test]
        //Prueba de método calcula ataque correcto, para verificar el acceso correcto
        //a los valores necesarios
        public void AtaqueTotalCorrecto()

        {
            merlin.AgregarElemento(vara);
            merlin.AgregarElemento(sombrero);
            Assert.AreEqual(25, merlin.CalcularAtaqueTotal());
        }

        [Test]
        public void DefensaTotalCorrecto()
        {
            merlin.AgregarElemento(vara);
            merlin.AgregarElemento(sombrero);
            Assert.AreEqual(15, merlin.CalcularDefensaTotal());
        }

        [Test]
        public void RecibeDanioCorrecto()
        {
            merlin.AgregarElemento(vara);
            merlin.AgregarElemento(sombrero);
            Mago dumbledore = new Mago ("Dumbledore");
            dumbledore.RecibirAtaque(merlin);
            Assert.AreEqual(75, dumbledore.Vida);
        }

        [Test]
        public void CuraCorrectamente()
        {
            merlin.AgregarElemento(vara);
            merlin.AgregarElemento(sombrero);
            Mago dumbledore = new Mago ("Dumbledore");
            dumbledore.RecibirAtaque(merlin);
            dumbledore.Curar();
            Assert.AreEqual(100, dumbledore.Vida);
        }

        [Test]
        public void NoRecibeDanioNegativo()
        {
            merlin.Curar();
            merlin.AgregarElemento(vara);
            merlin.AgregarElemento(sombrero);
            Sombrero seleccionador = new Sombrero ("Seleccionador");
            merlin.AgregarElemento(seleccionador);
            Mago dumbledore = new Mago ("Dumbledore");
            merlin.RecibirAtaque(dumbledore);
            Assert.AreEqual(100, merlin.Vida);
        }
    }
}