using System;
namespace Aula_Demo_Vetores
{
    public class SomaVetor
    {

        //construtor da classe
        public SomaVetor()
        {
            //sem itens para chamar
        }

        //método para somar os valores dentro de um vetor.
        public int somaValoresVetor(int[] vetor)
        {
            int soma = 0;

            //percorre todo o vetor [0], [1], [2]
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];    
            }

            //retorna o valor da soma
            return soma;
        }

        public int somaValoresVetor2(int[] vetor)
        {
            int x = 0;
            int soma = 0;

            while (x < vetor.Length)
            {
                soma = soma + vetor[x];
                ++x;
            }
            return soma;
        }

        public int somaValoresVetor3(int[] vetor)
        {
            int soma = 0;

            foreach(int v in vetor)
            {
                soma += v;
            }
            return soma;
        }
    }
}
