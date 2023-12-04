using System;
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);

            var numero = 88;
            Console.WriteLine(numero);
            
            object quantidade = 90;
            Console.WriteLine(quantidade);
           
            quantidade = "hhjkghg";
            Console.WriteLine(quantidade);
           
            texto = "oi";        
            Console.WriteLine(texto);
           
            int? idade = 0;
            Console.WriteLine(idade);
            
            idade = null;
            Console.WriteLine(idade);
           
            idade = 28;
            Console.WriteLine(idade);

            float real = 28.5f;
            int inteiro = 40;
            //real = inteiro;
            //inteiro = (int)real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);
            inteiro = Convert.ToInt32(real);
            Console.WriteLine(inteiro);
            
            int inteiroA = 100;
            uint inteiroSemSinal = (uint)inteiroA;
            Console.WriteLine(inteiroSemSinal);




           
        }
    }
}

