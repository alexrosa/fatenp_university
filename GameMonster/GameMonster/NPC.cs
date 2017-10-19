using System;
namespace GameMonster
{
    public class NPC
    {
        protected int vida;
        protected int dano;
        protected int velocidade;
        protected int xp ;
        protected int ouro ;
        protected float tempoAtaque ;


        public NPC(int vida, int dano, int velocidade, int xp, int ouro, float tempoAtaque)
        {
            this.vida = vida;
            this.dano = dano;
            this.velocidade = velocidade;
            this.xp = xp;
            this.ouro = ouro;
            this.tempoAtaque = tempoAtaque;
        }

		public NPC()
		{
			this.vida = 0;
			this.dano = 0;
			this.velocidade = 0;
			this.xp = 0;
			this.ouro = 0;
			this.tempoAtaque = 0;
		}

        public void mover()
        {
            Console.WriteLine("movendo de forma padrão...");    
        }
        public void atacar()
        {
            Console.WriteLine("atacando de forma padrão...");
		}

        public void morrer()
        {
            Console.WriteLine("morrendo de forma padrão...");
        }

	}
}
