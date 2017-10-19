using System;

namespace fatenp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dojo2 d = new Dojo2();
            int[] vetor = { 4, 5, 10, 20 ,30 };
            int retorno = d.maximoR(vetor, 5);
            Console.WriteLine("Quero {0}", retorno);
		}
    }
}
