using System;
using System.Collections;
namespace Stack
{
    /**
     * Implementação de uma pilha simples usando vetores para armazenar números.
     * Este mesmo exemplo poderá ser implementado usando Objetos ou GameObjects.
     */

    public class Stack{
        
        private int[] elementos;
        private int topo;
        /*
         * Construtor da classe. Nele instanciamos o nosso array (vetor) com 20 elementos (números).
         */
        public Stack(){
            elementos = new int[20];
            topo = -1;
        }

        public void push(int elemento){
            if (!isFull()){
                topo++;
                elementos[topo] = elemento;
            }
        }

        public int pop(){
            int e;
            e = elementos[topo];
            topo--;
            return e;
        }

        public int top(){
            return elementos[topo];
        }
        public bool isEmpty(){
            return (topo == -1);
        }

        public bool isFull(){
            return (topo == 19);
        }

    }
}
