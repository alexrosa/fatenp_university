using System;
using System.Collections;

namespace fatenplistaencadeada
{
    public class ListaEncadeada
    {
        public ListaEncadeada()
        {
            ArrayList listaEncadeada = new ArrayList();
            listaEncadeada.Add(999);

        }

        public int busca(int x, int[] v, int n)
        {
            int k;
            k = n - 1;

            while (k >= 0 && v[k] != x)
                k -= 1;
            return k;
        }

        /* Recebe x, v, e n >= 0 e devolve k tal que 0 <= k < n
         * e v[k] == x. Se tal k não existe, devolve -1
        */
        public int busca_recursiva(int x, int[] v, int n)
        {
            if (n == 0) return -1;
            if (x == v[n - 1]) return -1;

            return busca_recursiva(x, v, n - 1);
        }

        /* Remove o elemento do índice k do vetor v[0..n-1] e devolve o novo 
         * valor de n. A função supõe: 0 <= k < n
         */
        public int remover(int k, int[] v, int n)
        {
            int j;
            for (j = k; j < n - 1; j++)
            {
                v[j] = v[j + 1];    
            }
            return n - 1;
        }
        /*Insere y entre as posições k-1 e k do vetor v[0..n-1] 
         * e devolve o novo valor de n. Supõe que 0 <= k <= n.
         */
        public int insere(int k, int y, int[] v, int n)
        {
            int j;
            for (j = n; j > k; j--)
                v[j] = v[j - 1];
            v[k] = y;
            return n + 1;
        }
    }
}
