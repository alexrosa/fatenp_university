using System;

namespace ListaSimples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Lista ls = new Lista();
            ls.inserir(10);
            ls.inserir(5);
            ls.inserir(20);
            ls.inserir(30);

            ls.mostarUltimoNoInserido();
            ls.retirarNohEspecifico(20);
            ls.inserirNoIniciodaLista(100);
            ls.insereNoFinaldaLista(400);
            ls.listar();

            while (!ls.listaVazia())
                Console.WriteLine("removendo item {0}", ls.retirar());

            Console.ReadKey();
            
        }
    }
}
