using System;
namespace ListaEncadeadaSimples
{
    /**
     * Define a classe base (caixa) com um ponteiro para o próximo nó;
     */

    public class Node
    {
        //atributos do nó
        public int elemento { get; set; }
        public Node proximo { get; set; }
        public string arma { get; set; }

        //construtor da classe
        public Node(int elemento, Node proximo)
        {
            this.elemento = elemento;
            this.proximo = proximo;
        }
        //construtor com sobrecarga
        public Node(int elemento)
        {
            this.elemento = elemento;
            this.proximo = null;
        }
        //construtor simples (s/ sobrecarga de método)
		public Node()
		{
			this.elemento = 0;
            this.proximo = null;
		}
    }
}
