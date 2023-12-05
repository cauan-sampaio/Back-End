using System;
using System.ComponentModel;


namespace ElseIf
{
    public class IfElse
    {
        public static void MainIfElse(string[] args)
        {
            int idade = 18;
            int idadeMin = 21;
            int idadeMax = 65;
            if (idade >= idadeMin && idade < idadeMax)
            {
             Console.WriteLine("É diferente");
            } else
            {
                Console.WriteLine("É igual");
            }
            Console.WriteLine("Finalizou o programa");
        }
    }
}
