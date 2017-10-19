using System;

namespace ListaSimples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Prova prova = new Prova();

            int res = prova.fibonacci(8);
            Console.WriteLine("resultado {0}", res);
            
        }
    }
}
