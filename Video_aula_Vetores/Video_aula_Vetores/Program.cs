using System;

namespace Video_aula_Vetores
{
    class MainClass
    {
        //assinatura padrão usado na linguagem C - ponto de inicialização do programa
        public static void Main(string[] args)
        {
            SomaVetor somaVetor = new SomaVetor();
            int resultado_soma = somaVetor.somaValoresVetor();
            Console.WriteLine("Hello World!");
        }

    }
}
