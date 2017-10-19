using System;
namespace ListaSimples
{
    public class Nodo
    {
        public int elemento { get; set; }
        public Nodo proximo { get; set; } 

        public Nodo(int elemento, Nodo proximo)
        {
            this.elemento = elemento;
            this.proximo = proximo;
        }

        public Nodo()
        {
            this.elemento = 0;
            this.proximo = null; 
        }


    }













    public class Lista
    {
        private Nodo inicio;


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

            if (inicio == null){
                inicio = novo;
            }else{
                Nodo nodo_aux = inicio;
                while(nodo_aux.proximo != null)
                {
                    nodo_aux = nodo_aux.proximo;    
                }
                //insere o novo nó
                nodo_aux.proximo = novo;
            }
        }

        public int retirar()
        {
            Nodo aux = inicio;
            int elemento = aux.elemento;
            inicio = aux.proximo;
            return elemento;
        }

        public bool listaVazia()
        {
            return inicio == null;
        }


    }
}
