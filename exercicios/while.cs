using System;

namespace While
{
    class Program
    {
        static void MainWhile(string[] args)
        {
            int valor = 0;

            //while (valor <= 5)
            {
                Console.WriteLine(valor);//0 a 5
                valor++;
            }
            //while (valor <= 5)
            {
                valor++;
                Console.WriteLine(valor);//0 a 6
            }

            do {
                Console.WriteLine(valor);//0 a 5
                valor++;
            } while (valor < 5);
            

        }
    }
}