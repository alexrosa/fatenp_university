using System;
using System.Diagnostics;

namespace demoarray
{
    class MainClass
    {
        /*
         * Método de inicialização da aplicação
         */
        public static void Main(string[] args)
        {
            //declarando um array
            int[] numeros = new int[5];
            //mostrando o resultado 
            for (int i=0; i < numeros.Length; i++){
                if (i == 0) 
                    numeros[i] = 1;
                else 
                    numeros[i] = i * 100;
                //numeros[i] = i * 2;
                Console.WriteLine("o valor do array é: {0}", numeros[i]);
            }
            int b = busca(1, numeros);
			Console.WriteLine("o valor da busca: {0}", b);

            b = busca_recursiva(1, numeros, numeros.Length);
			Console.WriteLine("o valor da busca recursiva: {0}", b);

            //remoção pelo ultimo indice
            int[] v = remover(1, numeros, numeros.Length);
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine("Array alterado: {0}", v[i]);
            
            //remoção pelo indice
            v = insere(3, 10, numeros, numeros.Length-1);
			for (int i = 0; i < v.Length; i++)
			    Console.WriteLine("o valor inserido {0}", v[i]);

            int[] arr = new int[10];
            for (int i = arr.Length; i > 0; i--){
                arr[i-1] = i;
                Console.WriteLine("array = {0}",i);
            }


			Console.ReadKey();
		}

        public static int busca(int x, int[] v)
        {
            int k;
            k = v.Length -1;
            //busca valor dentro do array
            while (k >= 0 && v[k] != x)
                k -= 1;
            //retorna o valor (indexador)
            return k;
        }

        public static int busca_recursiva(int x, int[] v, int n)
        {
            if (n == 0)
                return -1;

            //ficará em loop (recursivo) até satisfazer o IF (Condição)
            if (x == v[n - 1])
                return n-1;
            
			//a busca chama o método novamente até satisfazer a condição acima.
			return busca_recursiva(x, v, n - 1);
        }

        //remove valor do último indice
        public static int[] remover(int k, int[]v, int n)
        {
            int j;
            for (j = k; j < n - 1; j++)
                v[j] = v[j + 1];
            v[j] = 0;
            return v;
        }

        //adiciona o valor do indice selecionado
		public static int[] insere(int k, int y, int[] v, int n)
		{
			int j;
			for (j = n; j > k; j--)
				v[j] = v[j - 1];
			v[k] = y;
            return v;
		}



	}
}
