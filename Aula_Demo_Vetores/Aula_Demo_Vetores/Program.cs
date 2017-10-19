using System;

namespace Aula_Demo_Vetores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SomaVetor somaVetor = new SomaVetor();
            //declaraco de vetor dinamica
            int[] vetor = new int[10];
            vetor[0] = 1;
            vetor[1] = 2;
            vetor[2] = 3;

            //declaracao de vetor estática
            int[] vetor2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//declaracao de vetor estática
			int[] vetor3 = { 10, 26, 34, 44, 55, 67, 79, 86, 91, 100 };

            //chama o método 1
			int resultado_soma = somaVetor.somaValoresVetor(vetor);
            Console.WriteLine("O valor da soma do vetor 1 é {0}", resultado_soma);

			//chama o método 2
			resultado_soma = somaVetor.somaValoresVetor2(vetor2);
            Console.WriteLine("O valor da soma do vetor 2 é {0}", resultado_soma);

			//chama o método 3
			resultado_soma = somaVetor.somaValoresVetor3(vetor3);
			Console.WriteLine("O valor da soma do vetor 3 é {0}", resultado_soma);


			//sempre que for usar o Console.ReadKey nunca usá-lo dentro de um loop
			Console.ReadKey();
        }
    }
}
