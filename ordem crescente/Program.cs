using System;

namespace ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            uint valor1,valor2;

            Console.Write("Digite um valor inteiro positivo: ");
            valor1 = uint.Parse(Console.ReadLine());

            Console.Write("Digite outro valor inteiro positivo: ");
            valor2 = uint.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine(valor2);
                Console.WriteLine(valor1);
            }
            else
            {
                Console.WriteLine(valor1);
                Console.WriteLine(valor2);
            }
        }
    }
}
