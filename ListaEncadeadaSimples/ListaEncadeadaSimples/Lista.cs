using System;
namespace ListaEncadeadaSimples
{
    public class Lista
    {
        protected Node inicio;

        //construtor da classe
        public Lista()
        {
            this.inicio = null;
        }

        //insere um novo nó na lista
        public void inserir(int elemento)
        {
            if (inicio == null)
            {
                inicio = new Node(elemento);
            }else{
                Node aux = inicio;
                while (aux.proximo != null){
                    aux = aux.proximo;
                }
                Node novo_no = new Node(elemento);
                aux.proximo = novo_no;    
            }
        }

		public void inserir(int elemento, string arma)
        {
			if (inicio == null)
			{
				inicio = new Node(elemento);
                inicio.arma = arma;
			}
			else
			{
				Node aux = inicio;
				while (aux.proximo != null)
				{
					aux = aux.proximo;
				}
				Node novo_no = new Node(elemento);
                novo_no.arma = arma;
				aux.proximo = novo_no;
			}
        }

		//retira o primeiro nó da lista
		public int retirar()
        {
			Node aux = inicio;
			int elemento = aux.elemento;
			inicio = aux.proximo;
			return elemento;
        }

        //mostra os itens da lista
        public string listar()
        {
            string str_aux = "";
            Node aux = inicio;
            while(aux != null)
            {
                if (str_aux == "")
                    str_aux = str_aux+""+aux.elemento;
                else
                    str_aux += "," + aux.elemento;
                
                aux = aux.proximo;
            }

            return "Mostrando os elementos " + str_aux;
        }

        //eh vazia
        public bool listaEstaVazia()
        {
            return (inicio == null);
        }
    }
}
