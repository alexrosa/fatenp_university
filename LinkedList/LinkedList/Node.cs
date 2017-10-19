using System;
namespace LinkedList
{
    //classe base (defini apenas os nós)
    public class Node
    {
        public object info {get;set;}
        public Node proximo {get;set;}

        //cria os construtores
        public Node(object info, Node next)
        {
            this.info = info;
            this.proximo = next;
        }
        //cria os construtores
        public Node(object info)
        {
            this.info = info;
            this.proximo = null;
        }

		//cria os construtores
		public Node()
		{
            this.info = null;
			this.proximo = null;
		}


	}

    public class LinkedList
    {
        protected Node header;

        public LinkedList()
        {
            header = new Node("header");
        }


        private Node busca(object item)
        {
            Node atual = new Node();
            atual = header;

            while(atual != item)
                atual = atual.proximo;
            
            return atual;
        }

        public void insereNodo(object newItem, object proximoNodo)
        {
            Node atual = new Node();
            Node novoNodo = new Node(newItem);

            atual = busca(proximoNodo);
            novoNodo.proximo = atual.proximo;
            atual.proximo = novoNodo;
        }

    }
}
