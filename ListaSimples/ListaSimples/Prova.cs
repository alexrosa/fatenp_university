using System;
namespace ListaSimples
{
    public class Prova
    {
        protected string[] vetor = { "Florianópolis", "São José", "Palhoça"
            ,"Biguaçu", "Governador Celso Ramos", "Paulo Lopes", "Santo Amaro" };

        public Prova()
        {
        }

        public void questao2a()
        {
            for (int i = vetor.Length; i > 0; i--)
            {
                Console.WriteLine("Cidade {0}", vetor[i]);
            }
        }
         
        public void questao2b(int pos)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i == pos)
                    vetor[i] = "";
            }
        }

        public int fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
            
        }
    }
}
