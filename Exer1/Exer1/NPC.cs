using System;
namespace Exer1
{
    public class NPC
    {
        public string nome { get; set; }
        public string tipoAtaque { get; set; }
        public float dano { get; set; }
        public string cor { get; set; }

        //definição do ponteiro
        public NPC proximo { get; set; }

        //construtor padrão
        public NPC()
        {
            this.nome = "";
            this.tipoAtaque = "";
            this.dano = 0f;
        }


        //construtor composto por atributos
        public NPC(string nome, string tipoAtaque, float dano)
        {
            this.nome = nome;
            this.tipoAtaque = tipoAtaque;
            this.dano = dano;
        }

    }
}
