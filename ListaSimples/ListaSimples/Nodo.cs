using System;
namespace ListaSimples
{
    public class Nodo
    {
        public int elemento { get; set; }
        public Nodo proximo { get; set; } 
        public Nodo anterior { get; set; }

        public Nodo(int elemento, Nodo proximo, Nodo anterior)
        {
            this.elemento = elemento;
            this.proximo = proximo;
            this.anterior = anterior;
        }

        public Nodo()
        {
            this.elemento = 0;
            this.proximo = null;
            this.anterior = null;
        }


    }


    public class Lista
    {
        private Nodo inicio;
        private Nodo final;


        public void listar()
        {
            if (inicio == null)
                Console.WriteLine("Lista vazia!!!");
            else{
                Nodo aux = inicio;
                while(aux != null){
                    Console.WriteLine("Mostrando elemento {0}", aux.elemento);
                    aux = aux.proximo;
                }
            }
        }

        public void inserir(int elemento)
        {
            Nodo novo = new Nodo();
            novo.elemento = elemento;
            novo.proximo = null;
            novo.anterior = null;

            if (inicio == null){
                inicio = novo;
                final = novo;
            }else{
                Nodo atual = inicio;
                Nodo ultimo = final;
                while(atual.proximo != null)
                {
                    ultimo = atual;
                    atual = atual.proximo;    
                }
                //insere o novo nó
                atual.proximo = novo;
                novo.anterior = ultimo;
                final = novo;
            }
        }

        public int retirar()
        {
            Nodo aux = inicio;
            int elemento = aux.elemento;
            inicio = aux.proximo;
            return elemento;
        }

        public int retirarNohEspecifico(int elemento)
        {
            Nodo atual = inicio;
            Nodo ultimo = final;

            while (atual.proximo != null)
            {
                ultimo = atual;
                atual = atual.proximo;

                if (elemento == atual.elemento)
                    break;
            }

            Nodo prox = atual.proximo;
            ultimo.proximo = prox;
            prox.anterior = ultimo;

            return elemento;
        }

        public void inserirNoIniciodaLista(int elemento)
        {
            Nodo novoNoh = new Nodo(elemento, null, null);

            if (inicio == null)
            {
                inicio = novoNoh;
                final = novoNoh;
            }else{
                //aponta o ponteiro anterior p/ o novo nó
                inicio.anterior = novoNoh;
                //aponta o próximo do novo nó p/ o início.
                novoNoh.proximo = inicio;
                //troca o nó inicial pelo novo nó.
                inicio = novoNoh;
            }
        }

        public void insereNoFinaldaLista(int elemento)
        {
            Nodo novoNoh = new Nodo(elemento, null, null);

            if (inicio == null)
            {
                inicio = novoNoh;
                final = novoNoh;
            }
            else
            {
                //deixa de ser o último nó da lista
                final.proximo = novoNoh;
                //copia a referência do ultimo nó p/ o novo
                novoNoh.anterior = final;
                //agora o último nó passa a ser o novo nó inserido.
                final = novoNoh;
            }
        }

        public void mostarUltimoNoInserido()
        {
            Console.WriteLine("Ultimo nó adicionado é {0}", final.elemento);
        }

        public bool listaVazia()
        {
            return inicio == null;
        }


    }
}
