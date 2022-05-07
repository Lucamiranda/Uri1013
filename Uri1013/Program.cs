using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encontrando o valor maior informado!
            int n1, n2, n3, maior, maiorABC;

            Console.WriteLine("Informe o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());

            maior = (n1 + n2 + Math.Abs(n1 - n2)) /2 ;
            maiorABC = (maior + n3 + Math.Abs(maior - n3)) /2;

            Console.WriteLine(maiorABC);
            Console.ReadLine();
        }
    }
}
