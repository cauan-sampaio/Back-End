using System;


namespace Operadores
{
    public class Operadores
    {
        public static void MainOperadores(string[] args)
        {
            int x = 36;
            x = 2 + 2; 
            Console.WriteLine(x);
            x += 4;
            Console.WriteLine(x);
            x++;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            Console.WriteLine(x != 8);
            Console.WriteLine(x == 8);
            Console.WriteLine(x >= 8);
            Console.WriteLine(x <= 8);
            ///TABELA VERDADE DE LÓGICA E, OU, NEGAÇÃO
            int y = 30;
            bool entre = (x > 25) && (x < 40);
            bool ou = (y > 25) || (y < 10);
            bool negacao = !(y<25);
            Console.WriteLine($"Entre: {entre}, Ou: {ou}, Negacao: {negacao}");

        }
    }
}
