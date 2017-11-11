using System;
using System.Collections;

namespace Exer1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Lista ls = new Lista();

            ls.inserir("Mumia", "Canta", 30f);
            ls.inserir("Dracula", "Corte", 45.5f);
            ls.inserir("Mun ha", "Magia", 50.5f);
            ls.inserir("Frankstein", "Parte", 70f);
            ls.inserir("Zumbi", "Vomita", 138.8f);

            /*
            ArrayList lista = new ArrayList();
            NPC npc = new NPC("Mumia", "Canta", 30f);
            lista.Add(npc);
            npc = new NPC("Dracula", "Canta", 30f);
            lista.Add(npc);
            npc = new NPC("Mun ha", "Canta", 30f);
            lista.Add(npc);
            npc = new NPC("Zumbi", "Canta", 30f);
            lista.Add(npc);

            foreach(NPC npcz in lista){
                Console.WriteLine("nome {0}", npcz.nome);
            }
            lista.Remove(1);
            */
            //varial de controle
            bool condicao = true;
            //looping finito, até ordem do usuário

            while (condicao)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Tipo Ataque: ");
                string tp_ataque = Console.ReadLine();

                Console.Write("Dano: ");
                float dano = float.Parse(Console.ReadLine());

                //insere o nova caixa na lista
                ls.inserir(nome, tp_ataque, dano);

                Console.Write("Deseja continuar: ");
                string userCond = Console.ReadLine();

                condicao = (userCond.ToLower() == "s");
            }



            ls.removerEspecifico("Mun ha");
            ls.listar();
            ls.retirar();

            Console.ReadKey();
        }
    }
}
