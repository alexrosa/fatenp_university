using System;

namespace Exercicio1lista
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ListaMonstros lmonstros = new ListaMonstros();
            lmonstros.insereMonstro("Drácula", "Mordida", 50);
            lmonstros.insereMonstro("Frankstein", "Soco", 40);
            lmonstros.insereMonstro("Mumia", "Magia", 80);
            lmonstros.insereMonstro("Zumbi", "Mordida", 100);
            lmonstros.insereMonstro("Munha",  "Magia", 30);

            lmonstros.listaMonstros();

            lmonstros.removeMonstroEspecifico("Zumbi");

            while (!lmonstros.listaEstaVazia())
            {
                string nome = lmonstros.removeMonstro();
                Console.WriteLine("Removendo monstro = {0}", nome);
            }
                
            
        }
    }
}
