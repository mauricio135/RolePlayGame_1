using NUnit.Framework;
using RolePlayGame_1;
using RolePlayGame_1.Library;

namespace Library.Test
{
    public class TestsDementor
    {
        private Dementor h = new Dementor ("Ache");
        private IElemento capita = new Capa ("Capa Invisibilidad");
        private IElemento daga = new Daga ("Daga Mortal"); 


        [Test]
        
        public void AtaqueTotalCorrecto()

        {
            h.AgregarElemento(capita);
            h.AgregarElemento(daga);
            Assert.AreEqual(40, h.CalcularAtaqueTotal());
        }

        [Test]
        public void DefensaTotalCorrecto()
        {
            h.AgregarElemento(capita);
            h.AgregarElemento(daga);
            Assert.AreEqual(16, h.CalcularDefensaTotal());
        }

        [Test]
        public void AgregaElementoCorrectamente()
        {
            h.AgregarElemento(daga);
            Dementor dum = new Dementor ("Dum");
            Assert.IsNotNull(dum.Elementos);
            
        }

        [Test]
        public void CuraCorrectamente()
        {
            h.AgregarElemento(capita);
            h.AgregarElemento(daga);
            Dementor didi = new Dementor ("Didi");
            didi.RecibirAtaque(h);
            didi.Curar();
            Assert.AreEqual(100, didi.Vida);
        }

        
    }
}
