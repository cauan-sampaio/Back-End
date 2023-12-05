using System;

namespace Metodos
{
    class Program
    {
        static void MainMetodos(string[] args)
        {
            MeuMetodo();
            string nome = RetornaNome("André", "Baltieri");
            Console.WriteLine(nome);
        }
        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }
        static string RetornaNome(string nome, string sobrenome, int idade = 20)
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }
    }
}
