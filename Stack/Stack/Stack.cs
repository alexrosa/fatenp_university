using System;
using System.Collections;
namespace Stack
{
    public class Stack
    {
        //private int[] elementos;
        private ArrayList lista;
        private int topo;

        public Stack()
        {
            lista = new ArrayList();
            //elementos = new int[10];
            topo = -1;
        }

        public void push(int elemento){
            if (!isFull()){
                topo++;
                lista.Add(elemento);
                //elementos[topo] = elemento;
            }
        }

        public int pop(){
            int e;
            //e = elementos[topo];
            e = (int)lista[topo];
            topo--;
            return e;
        }

        public int top(){
            //return elementos[topo];
            return lista.Count;
        }
        public bool isEmpty(){
            return (topo == -1);
        }

        public bool isFull(){
            return (topo == 9);
        }

    }
}
