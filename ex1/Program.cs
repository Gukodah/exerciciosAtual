using System;
using System.Diagnostics;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String ao contrario digite - 1");
            Console.WriteLine("Descontar 5%, 5 vezes - 2");
            Console.Write("Selecione um exercicio: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Exercicio1 ex1 = new Exercicio1();

                    Console.Write("Digite uma string para obter o seu inverso: ");

                    Console.Write($"\nResultado: { ex1.reverse( Console.ReadLine() ) }");

                    break;

                case "2":

                    Console.Clear();
                    Exercicio2 ex2 = new Exercicio2();

                    Console.Write("Digite um numero para processar: ");

                    Console.Write($"\nResultado: {  ex2.discountsFivePercentFiveTimes( double.Parse( Console.ReadLine() ) ) }");
         
					break;
            }

        }
    }
}
