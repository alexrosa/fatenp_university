using System;

namespace ListaEncadeadaSimples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //criando o objeto lista
            Lista lst = new Lista();
            string[] armas = { "Pexeira", "Katana", "Espada", "Revolver"
                              , "Bola de gude", "Magia negra" };
            
            //inserindo dados na lista ou itens
            for (int i = 0; i < armas.Length; i++)
            {
                lst.inserir(i, armas[i]);    
            }

            //mostrando itens da lista
            Console.WriteLine("Listando... {0}", lst.listar());


            lst.retirar();
            //removendo os itens da lista
            while(!lst.listaEstaVazia()) 
                Console.WriteLine("Removendo o elemento {0}", lst.retirar());

            Console.ReadKey();
        }
    }
}
