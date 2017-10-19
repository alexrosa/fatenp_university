using System;
namespace Exercicio1lista
{
    public class ListaMonstros
    {
        private Monstro inicio;

        public ListaMonstros()
        {
            inicio = null;
        }

        public void insereMonstro(string nome, string tpAtaque, int dano)
        {
            //item - primeiro item a ser inserido na lista
            if (inicio == null)
            {
                Monstro aux = new Monstro(nome, tpAtaque, dano);
                inicio = aux;  
            }else{
                Monstro aux = inicio;
                while(aux.proximo != null)
                {
                    aux = aux.proximo;    
                }
                Monstro novo_monstro = new Monstro(nome, tpAtaque, dano);
                aux.proximo = novo_monstro;
            }

        }

        //remove o primeiro monstro inserido na lista
        public string removeMonstro()
        {
            Monstro aux = inicio;
            string nomeMonstro = aux.nome;
            inicio = aux.proximo;
            return nomeMonstro;
        }
        //lista monstro
        public void listaMonstros()
        {
            Monstro aux = inicio;
            while(aux != null)
            {
                Console.WriteLine("Listando Monstro: {0}, Tipo de Ataque {1} e Dano Causado = {2}", aux.nome, aux.tipoAtaque, aux.dano);
                aux = aux.proximo;
            }
        }

        public bool listaEstaVazia()
        {
            return (inicio == null);
        }

        //remove monstro específico da lista
        public string removeMonstroEspecifico(string nome)
        {
            Monstro aux = inicio;
            //variável para armazenar os dados do nó anterior.
            Monstro anterior = null;

            string monstroRemovido = "";
            while (aux != null)
            {
                //comparando o nome que estamos buscando
                if (aux.nome == nome)
                {
                    monstroRemovido = aux.nome;
                    break;
                }
                //controlando a navegação dos nós
                anterior = aux;
                aux = aux.proximo;
            }
            //remove o nó com o nome específico.
            anterior.proximo = aux.proximo;
            return monstroRemovido;
        }
    }
}
