using System;

namespace Stack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack pilha = new Stack();
            pilha.push(1);
            pilha.push(2);
            pilha.push(3);
            pilha.push(4);
            pilha.push(5);
            pilha.push(6);
            pilha.push(7);
            pilha.push(8);
            pilha.push(9);
            pilha.push(10);
            pilha.push(11);
            pilha.push(12);
            Console.WriteLine("Parou!");

            while(!pilha.isEmpty()){
                Console.WriteLine("Desempilhando item "+pilha.pop());
            }

        }
    }
}
