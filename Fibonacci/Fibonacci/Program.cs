using System;

namespace Fibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            int retorno = fibo(10);
            Console.WriteLine("Retorno serie fibonacci {0}", retorno);
            */
            int[] a = {1, 2, 3};
            int[] b = new int[2];

            int[] ret = copiaVetor(a, b);

            for (int i = 0; i < ret.Length; i++)
                Console.WriteLine("Item {0} valor {1}", i, ret[i]);

            Console.ReadKey();
        }

        public static int[] copiaVetor(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];    
            }
            return b;
        }


        public static int fibo(int n)
        {
            if (n < 2)
                return n;
            else
                return fibo(n - 1) + fibo(n - 2);
        }
    }


}
