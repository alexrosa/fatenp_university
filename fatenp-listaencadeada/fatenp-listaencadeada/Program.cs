using System;
using System.Collections.Generic;

namespace fatenplistaencadeada
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Aluno> lista_de_alunos = new List<Aluno>();
            lista_de_alunos.Add(new Aluno("Alexandre", "Qualquer um"));
            lista_de_alunos.Add(new Aluno("Alexandre2", "Qualquer dois"));
            foreach(Aluno al in lista_de_alunos)
            {
                Console.WriteLine("aluno: {0}", al.nome);    
                Console.WriteLine("endereço: {0}", al.endereco);
			}
        }
    }

    //private class
    class Aluno
    {
        public string nome { get; set; }
        public string endereco { get; set; }

        public Aluno (string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }    
        
    }
}
