using System;
namespace Exer1
{
    public class Lista
    {
        private NPC inicio { get; set; }

        public Lista()
        {
            inicio = null;
        }

        public void inserir(string nome, string tipoAtaque, float dano)
        {
            NPC novo_noh = new NPC(nome, tipoAtaque, dano);
            novo_noh.proximo = null;

            if (inicio == null)
            {
                inicio = novo_noh;

            }else{
                NPC aux = inicio;

                //fazer looping até o final da lista
                while(aux.proximo != null){
                    aux = aux.proximo;
                }
                aux.proximo = novo_noh;
            }
        }

        public void listar()
        {
            NPC aux = inicio;
            while(aux != null){
                Console.WriteLine("Mostrando NPC nome {0}, tipo de ataque = {1}, dano = {2}", aux.nome, aux.tipoAtaque, aux.dano);
                aux = aux.proximo;
            }
        }

        public string retirar()
        {
            if (listaEstaVazia())
                return "Não existem usuários a serem removidos!";
            
             NPC aux = inicio;
             string nomeNPC = inicio.nome;
             inicio = aux.proximo;
             return nomeNPC;
        }

        //remove nó específico, através do nome
        public string removerEspecifico(string nome)
        {
            NPC aux = inicio;
            NPC atual = inicio;
            while (aux != null)
            {
                atual = aux;
                aux = aux.proximo;
                         
                if (aux.nome == nome){
                    break;
                }
            }
            atual.proximo = aux.proximo;
            return nome;
        }

        public bool listaEstaVazia()
        {
            return (inicio == null);
        }

    }
}
