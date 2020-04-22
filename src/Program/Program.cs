using System;
using System.Collections;


namespace RolePlayGame_1.Library
{
    class Program
    {
        static void Main(string[] args)
        {
           Elfo Dooby= new Elfo("Dooby");
           Elfo Belatrix=new Elfo("Belatrix");
           Elemento dagaBelatrix=new Elemento("Daga Belatrix",101,0);
           Elemento Calcetin=new Elemento("Calcetín",0,3);
           Dooby.AgregarElemento(Calcetin);
           Belatrix.AgregarElemento(dagaBelatrix);

           //Belatrix ataca a dobby
           Dooby.Vida=Dooby.Vida-Belatrix.CalcularAtaqueTotal();
           Console.WriteLine(Dooby.Nombre+  "\t" + "Vivo:  "+ Dooby.TieneVida());
        
        }
    }
}   