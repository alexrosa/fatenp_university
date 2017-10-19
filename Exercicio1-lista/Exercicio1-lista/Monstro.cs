using System;
namespace Exercicio1lista
{
    public class Monstro
    {

        public string nome { get; set; }
        public string tipoAtaque { get; set; }
        public int dano { get; set; }

        //ponteiro - apontará para o próximo objeto do tipo monstro.
        public Monstro proximo { get; set; }

        //construtor simples
        public Monstro()
        {
            this.nome = "";
            this.tipoAtaque = "";
            this.dano = 0;
        }

        //construtor composto
        public Monstro(string nome, string tipoAtaque, int dano)
        {
            this.nome = nome;
            this.tipoAtaque = tipoAtaque;
            this.dano = dano;
        }
    }
}
