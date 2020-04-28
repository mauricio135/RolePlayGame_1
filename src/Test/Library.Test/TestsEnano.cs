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
        //Se Valida que el Enano se imprima con el texto que se espera.
        [Test]
        public void ImprimeDatosDeEnano()
        {
            IPersonaje pequeño = new Enano("Enano1");
            IElemento elemento = new Hacha("Hacha Magica");
            pequeño.AgregarElemento(elemento);
            string esperado = "El Enano Enano1 tiene 100 puntos de Vida y los siguientes elementos:  'Hacha Magica' (10/1) ";
            Assert.AreEqual(esperado, pequeño.GetTextToPrint());
        }
        //Se Valida que el Enano atacado tenga la vida correcta en base a el poder de ataque y defensa suyo y de su atacante.
        [Test]
        public void AtacoAlEnanoYValidoCuantoLeQuedaDeVida()
        {
            IPersonaje pequeño1 = new Enano("Enano1");
            IElemento elemento1 = new Hacha("Hacha Magica");
            pequeño1.AgregarElemento(elemento1);

            IPersonaje pequeño2 = new Enano("Enano2");
            IElemento elemento2 = new Hacha("Hacha Mistica");
            pequeño2.AgregarElemento(elemento1);

            pequeño1.RecibirAtaque(pequeño2);

            //Se espera que tenga 91 de Vida luego de ser atacado ya que las hachas tienen 10 de ataque y 1 de defensa
            int esperado = 91;
            Assert.AreEqual(esperado, pequeño1.Vida);

        }
        //Se Valida que el Enano retorne el valor correcto de Ataquetotal en base a sus elementos
        [Test]
        public void VerificoQueElTotalDeAtaqueCalculadoSeaCorreto()
        {
            IPersonaje pequeño1 = new Enano("Enano1");
            IElemento elemento1 = new Hacha("Hacha Magica");
            IElemento elemento2 = new Hacha("Hacha Mistica");
            pequeño1.AgregarElemento(elemento1);
            pequeño1.AgregarElemento(elemento2);

            //Se espera que tenga 20 de poder de ataque sumando el ataque de dos Hachas.
            int esperado = 20;
            Assert.AreEqual(esperado, pequeño1.CalcularAtaqueTotal());

        }
        //Se Valida que el Enano retorne el valor correcto de DefensaTotal en base a sus elementos
        [Test]
        public void VerificoQueElTotalDeDefensaCalculadoSeaCorreto()
        {
            IPersonaje pequeño1 = new Enano("Enano1");
            IElemento elemento1 = new Hacha("Hacha Magica");
            IElemento elemento2 = new Hacha("Hacha Mistica");
            pequeño1.AgregarElemento(elemento1);
            pequeño1.AgregarElemento(elemento2);

            //Se espera que tenga 2 de poder de defensa sumando la defensa de dos Hachas.
            int esperado = 2;
            Assert.AreEqual(esperado, pequeño1.CalcularDefensaTotal());

        }
        //Se Valida que el Enano Cumpla con que n tiene Vida si se lo ataca varias veces hasta llegar a Vida = Cero
        [Test]
        public void VerificoQueElEnanoRetorneQueNoTieneVidaLuegoDeAtacarlo()
        {
            IPersonaje pequeño1 = new Enano("Enano1");
            IElemento elemento1 = new Hacha("Hacha Magica1");
            IElemento elemento2 = new Hacha("Hacha Mistica2");
            IElemento elemento3 = new Hacha("Hacha Mistica3");
            IElemento elemento4 = new Hacha("Hacha Mistica4");
            IElemento elemento5 = new Hacha("Hacha Mistica5");
            IElemento elemento6 = new Hacha("Hacha Mistica6");
            IElemento elemento7 = new Hacha("Hacha Mistica7");
            IElemento elemento8 = new Hacha("Hacha Mistica8");            
            IElemento elemento9 = new Hacha("Hacha Mistica9");
            IElemento elemento10 = new Hacha("Hacha Mistica10");
            
            pequeño1.AgregarElemento(elemento1);
            pequeño1.AgregarElemento(elemento2);
            pequeño1.AgregarElemento(elemento3);
            pequeño1.AgregarElemento(elemento4);
            pequeño1.AgregarElemento(elemento5);
            pequeño1.AgregarElemento(elemento6);
            pequeño1.AgregarElemento(elemento7);
            pequeño1.AgregarElemento(elemento8);            
            pequeño1.AgregarElemento(elemento9);
            pequeño1.AgregarElemento(elemento10);  

            Enano pequeño2 = new Enano("Enano2");
            pequeño2.RecibirAtaque(pequeño1);
            
            //Se espera que pequeño2 no tenga vida luego de ser atacado varias veces por pequeño1 TieneVida deberia de retornar False.
           
            Assert.IsFalse(pequeño2.TieneVida());

        }

    }
}

