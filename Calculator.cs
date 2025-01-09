namespace POO_CSharp_P7
{
    internal class Calculator
    {
        //Solução ruim com diversas sobrecargas:
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        //Solução com Vetor
        //Utilizando modificador params
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //Trabalhando com o modificador ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        //Trabalhando com o modificador out
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
