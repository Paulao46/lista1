using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paulod251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            string nome;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine(nome + ", a soma dos número {0} mais {1} é igual a: {2}", n1, n2, soma);

        }
    }
}
