using System;

namespace POO_CSharp_P7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Sintaxe opcional: laço foreach
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("------------------------------------");
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            //Trabalhando com o modificador ref
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine();

            //trabalhando com o modificador out
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
            Console.WriteLine();

            //Versão sem modificador
            Console.WriteLine("Versão sem modificador");
            int s1 = Calculator.Sum(new int[] { 2, 3 });
            int s2 = Calculator.Sum(new int[] { 2, 4, 3 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("Versão com o modificador Params");
            int s3 = Calculator.Sum(2, 3);
            int s4 = Calculator.Sum(2, 4, 3);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine();
        }
    }
}