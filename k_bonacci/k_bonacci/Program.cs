using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_bonacci
{
    class Program
    {

        static int verifica_k()
        {
            Console.Write("Informe o k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            while (k < 1 || k > 103)
            {
                Console.WriteLine("O k deve estar entre 1 e 103.");
                Console.Write("Informe o k: ");
                k = Convert.ToInt32(Console.ReadLine());
            }
            return k;
        }

        static int verifica_n()
        {
            Console.Write("Informe o n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Kbonacci kbonacci = new Kbonacci();
            while (n < 0 || n > 25000)
            {
                Console.WriteLine("O n deve estar entre 0 e 25000.");
                Console.Write("Informe o n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            return n;
        }

        static void Main(string[] args)
        {
            int k = verifica_k();
            int n = verifica_n();
            long resp;
            Kbonacci kbonacci = new Kbonacci();
            resp = kbonacci.k_bonacci(k, n);
            Console.WriteLine("Resposta: " + resp);
            Console.ReadKey();
        }
    }
}
