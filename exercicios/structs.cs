using System;

namespace Struct
{
    class Program

    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouser gamer", 8, EProductType.Product);
            var manutencaoEle = new Product(2, "Manuntenção elétrica residencial ", 500, EProductType.Service);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type);


        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar( double dolar)
        {
            return Price * dolar;
        }

    }

    enum EProductType {
        Product = 1,
        Service = 2
    }
}