using System;

namespace RolePlayGame_1.Library
{
public class PrintEnano
{
    // Al igual que en el Ejemplo de "Sale" visto en el material Teorico, utilizamos como criterio el Patron SRP para
    // Separar responsabilidades del metodo de impresion. 
 public static void ConsolePrintEnano(Enano enano)
 {
 Console.WriteLine(enano.GetTextToPrint());
 }
}
}